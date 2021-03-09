using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceAFIS.Simple;
using System.Windows.Media.Imaging;
using Emgu.CV.CvEnum;

namespace PratkicniDio_Zavrsni
{
    public partial class FormAplikacija : Form
    {
        //prenosenje objekta na formu prikazLozinki
        public static string korisnickoImePrijenos = "";

        //varijable potrebne za rad s prepoznavanjem lica
        Image<Bgr, Byte> currentFrame;
        Capture camera;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;

        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();

        List<string> listaKorisnikaLica = new List<string>();
        int brojKorisnikaLica;

        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;

        public FormAplikacija()
        {
            InitializeComponent();

            //Ucitavanje cascade za detekciju lica
            face = new HaarCascade("haarcascade_frontalface_default.xml");

            DohvacanjeSvihLica();
        }

        Person NepoznataOsoba = new Person();
        List<Person> ListaOsobaIzBaze = new List<Person>();

        ///kreiranje instance za fingerprint
        static AfisEngine Afis = new AfisEngine();

        //Provjera prilikom prijave
        bool zastavicaPrst = false;
        bool zastavicaLice = false;

        public bool ProvjeraPrsta()
        {
            if(zastavicaPrst == false)
            {
                picBoxPotvrdaPrsta.Image = Image.FromFile(Application.StartupPath + "/Icons/fingerFalse.png");
                return false;
            }
            else
            {
                picBoxPotvrdaPrsta.Image = Image.FromFile(Application.StartupPath + "/Icons/fingerTrue.png");
                return true;
            }
        }

        public bool ProvjeraLica()
        {
            if (zastavicaLice == false)
            {
                picBoxPotvrdaLica.Image = Image.FromFile(Application.StartupPath + "/Icons/faceFalse.png");
                return false;
            }
            else
            {
                picBoxPotvrdaLica.Image = Image.FromFile(Application.StartupPath + "/Icons/faceTrue.png");
                return true;
            }
        }

        public void ProvjeraPrijave()
        {
            if(ProvjeraPrsta() || ProvjeraLica() == false)
            {
                picBoxPotvrdaPrijave.Image = Image.FromFile(Application.StartupPath + "/Icons/PrijavaFalse.png");
                btnPrijava.Enabled = false;
            }
            if(ProvjeraPrsta() && ProvjeraLica() == true)
            {
                picBoxPotvrdaPrijave.Image = Image.FromFile(Application.StartupPath + "/Icons/PrijavaTrue.png");
                btnPrijava.Enabled = true;
            }
        }


        //Dohvacanje svih lica iz baze i ljudi uz njih
       public void DohvacanjeSvihLica()
        {
            try
            {
                //Load of previus trainned faces and labels for each image

                //Dohvacanje slika lica u trainingImages
                List<Uzorak_lica> privremenaListaUzoraka = new List<Uzorak_lica>();
                privremenaListaUzoraka = Uzorak_lica.DohvatiUzorke();
                foreach (var item in privremenaListaUzoraka)
                {
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + item.LicePutanja));

                }
                brojKorisnikaLica = trainingImages.Count();
                ContTrain = brojKorisnikaLica;

                //Dohvacanje svih korisnickih imena
                List<Korisnik> privremenaListaKorisnika = new List<Korisnik>();
                privremenaListaKorisnika = Korisnik.DohvatiSveKorisnike();
                foreach (var item in privremenaListaKorisnika)
                {
                    listaKorisnikaLica.Add(item.Korisnicko_ime);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Baza podataka ne sadrzi niti jednog korisnika.");
            }
        }

        private void btnPrepoznajLice_Click(object sender, EventArgs e)
        {
            DohvacanjeSvihLica();
            //Initialize the capture device
            camera = new Capture();
            camera.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            //btnPrepoznajLice.Enabled = false; -->kod
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            currentFrame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face,1.2,10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);

                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       listaKorisnikaLica.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);
                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    
                }
            }

            cameraBoxPocetna.Image = currentFrame;
        }

        private void FormAplikacija_Load(object sender, EventArgs e)
        {
            ProvjeraPrijave();
        }

        private void btnPrihvatiPrepoznato_Click(object sender, EventArgs e)
        {
            if (name == textBoxKorIme.Text)
            {
                zastavicaLice = true;
                lblFaceTocnost.Text = name;
                lblFaceTocnost.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                zastavicaLice = false;
            }
            ProvjeraPrijave();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija frmRegistracija = new Registracija();
            frmRegistracija.ShowDialog();
           
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {

            this.Hide();
            korisnickoImePrijenos = textBoxKorIme.Text;
            PrikazLozinki frmPrijava = new PrikazLozinki();
            frmPrijava.ShowDialog();
            this.Close();
        }

        private void btnProvjeraPrsta_Click(object sender, EventArgs e)
        {
            List<Otisak_prsta> listaOtisaka = new List<Otisak_prsta>();
            listaOtisaka = Otisak_prsta.DohvatiOtiske();
            foreach (var item in listaOtisaka)
            {
                Fingerprint fp = new Fingerprint();
                fp.AsBitmap = new Bitmap(Bitmap.FromFile(Application.StartupPath + item.Otisak_putanja));
                Person osoba = new Person();
                osoba.Id = item.FK_korisnik;
                osoba.Fingerprints.Add(fp);
                Afis.Extract(osoba);
                ListaOsobaIzBaze.Add(osoba);
            }

            Afis.Threshold = 40;
            Person matchingCandidate = Afis.Identify(NepoznataOsoba, ListaOsobaIzBaze).FirstOrDefault();
            if (matchingCandidate == null)
            {
                MessageBox.Show("Nije pronadena osoba s navedenim otiskom prsta!");
            }
            else
            {
                Korisnik trazeniKorisnik = new Korisnik();
                trazeniKorisnik = Korisnik.DohvatiKorisnika(matchingCandidate.Id);
                float score = Afis.Verify(NepoznataOsoba, matchingCandidate);
                bool match = (score > 0);
                MessageBox.Show("Pronađen je korisnik: " + trazeniKorisnik.Korisnicko_ime + " s koeficijentom podudranja: " + score.ToString());
                if(trazeniKorisnik.Korisnicko_ime == textBoxKorIme.Text)
                {
                    zastavicaPrst = true;
                    lblOsobaFinger.Text = trazeniKorisnik.Korisnicko_ime;
                    lblOsobaFinger.ForeColor = System.Drawing.Color.Green;
                    lblFingerTocnost.Text = score.ToString();
                    lblFingerTocnost.ForeColor = System.Drawing.Color.Green;
                }
            }
            ProvjeraPrijave();
        }

        private void btnOcitajPrst_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFileDialog = new OpenFileDialog();
            if (dlgOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image SlikaZaTest = Bitmap.FromFile(dlgOpenFileDialog.FileName);
                picBoxProvjeraPrsta.Image = SlikaZaTest;

                //testiranje slike
                Fingerprint fp1 = new Fingerprint();
                fp1.AsBitmap = new Bitmap(Bitmap.FromFile(dlgOpenFileDialog.FileName));
                NepoznataOsoba.Fingerprints.Add(fp1);
                Afis.Extract(NepoznataOsoba);
            }
        }
    }
}
