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

namespace PratkicniDio_Zavrsni
{
    public partial class Registracija : Form
    {
        private Korisnik Novikorisnik;
        private Otisak_prsta NoviOtisak;
        private Uzorak_lica NoviUzorak;

        //Deklariranje varijabli za cijeli FaceRecognition
        MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        HaarCascade faceDetected;
        Image<Bgr, Byte> Frame;
        Capture camera;
        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace = null;
        Image<Gray, byte> grayFace = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> Users = new List<string>();
        int Count;
        string name, names = null;

        public Registracija()
        {
            InitializeComponent();
            faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");
           
        }

        private void btnRegistraj_Click(object sender, EventArgs e)
        {
            //registracija u tablicu korisnik
            Novikorisnik = new Korisnik();
            Novikorisnik.Ime = textBoxIme.Text;
            Novikorisnik.Prezime = textBoxPrezime.Text;
            Novikorisnik.Korisnicko_ime = textBoxKorIme.Text;
            Novikorisnik.Registriraj();

            //registracija u tablicu otiska prsta
            NoviOtisak = new Otisak_prsta();
            NoviOtisak.FK_korisnik = Novikorisnik.DohvatiID();
            NoviOtisak.Otisak_putanja = "/FingerPrints/Print" + textBoxKorIme.Text + ".bmp";
            NoviOtisak.SpremiOtisak();

            //registracija u tablicu uzorka lica
            NoviUzorak = new Uzorak_lica();
            NoviUzorak.FK_korisnik = Novikorisnik.DohvatiID();
            NoviUzorak.LicePutanja = "/Faces/Face" + textBoxKorIme.Text + ".bmp";
            NoviUzorak.SpremiUzorak();

            this.Close();
            
        }

        private void btnSpremiSliku_Click(object sender, EventArgs e)
        {
            //spremanje u bazu slika
            grayFace = camera.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            MCvAvgComp[][] DetectedFaces = grayFace.DetectHaarCascade(faceDetected, 1.1, 3, 0, new Size(20, 20));
            foreach (MCvAvgComp f in DetectedFaces[0])
            {
                TrainedFace = Frame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            TrainedFace.Save(Application.StartupPath + "/Faces/Face" + textBoxKorIme.Text + ".bmp");
            pictureBoxLica.Image = Bitmap.FromFile(Application.StartupPath + "/Faces/Face" + textBoxKorIme.Text + ".bmp");
        }

        private void btnOdaberiPrst_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpenFileDialog = new OpenFileDialog();
            if (dlgOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image PrvaSlika = Bitmap.FromFile(dlgOpenFileDialog.FileName);
                pictureBoxPrst.Image = PrvaSlika;
                PrvaSlika.Save(Application.StartupPath + "/FingerPrints/Print" + textBoxKorIme.Text + ".bmp");
            }
        }

        private void btnPrepoznavanjeLica_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcedure);
        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();
            MCvAvgComp[][] faceDetectedNow = grayFace.DetectHaarCascade(faceDetected, 1.1, 3, 0, new Size(20, 20));
            foreach (MCvAvgComp f in faceDetectedNow[0])
            {
                result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Frame.Draw(f.rect, new Bgr(Color.Green), 2);
                if (trainingImages.ToArray().Length != 0)
                {
                    MCvTermCriteria termCriterias = new MCvTermCriteria(Count, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 2500, ref termCriterias);
                    name = recognizer.Recognize(result);
                    Frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                }
            }
            cameraBox.Image = Frame;
        }
    }
}
