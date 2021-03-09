using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PratkicniDio_Zavrsni
{
    public partial class PrikazLozinki : Form
    {

        Korisnik prijavljeniKorisnik = new Korisnik();
        List<Aplikacija> listaAplikacija = new List<Aplikacija>();
        Aplikacija novaAplikacija = new Aplikacija();
        Aplikacija odabranaAplikacija = new Aplikacija();


        public PrikazLozinki()
        {
            InitializeComponent();
        }

        

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrikazLozinki_Load(object sender, EventArgs e)
        {
            prijavljeniKorisnik = Korisnik.DohvatiKorisnikaPomocuKorime(FormAplikacija.korisnickoImePrijenos);
            labelaIme.Text = prijavljeniKorisnik.Ime;
            labelaPrezime.Text = prijavljeniKorisnik.Prezime;
            pictureBoxStrelica.Image = Image.FromFile(Application.StartupPath + "/Icons/strelica.png");
            OsvjeziAplikacije();
            
        }

        private void OsvjeziAplikacije()
        {
            listaAplikacija = Aplikacija.DohvatiAplikacije(prijavljeniKorisnik);
            dgvAplikacije.DataSource = listaAplikacija;
            dgvAplikacije.Columns[0].Visible = false;
            dgvAplikacije.Columns[2].Visible = false;
            dgvAplikacije.Columns[1].HeaderText = "Naziv";
            
        }

        private void btnUnosApp_Click(object sender, EventArgs e)
        {
            novaAplikacija.Naziv = textBoxNovaApp.Text;
            novaAplikacija.FK_korisnik = prijavljeniKorisnik.ID_korisnik;

            novaAplikacija.DodajAplikaciju();
            OsvjeziAplikacije();
            textBoxNovaApp.Clear();
        }

        private void btnObrisiApp_Click(object sender, EventArgs e)
        {
            Aplikacija odabranaAplikacija = dgvAplikacije.CurrentRow.DataBoundItem as Aplikacija;
            if(odabranaAplikacija != null)
            {
                odabranaAplikacija.ObrisiAplikaciju();
                OsvjeziAplikacije();
            }
        }

        private void OsvjeziKorRacune()
        {
            dgvRacuni.DataSource = null;
            Aplikacija odabranaAplikacija = dgvAplikacije.CurrentRow.DataBoundItem as Aplikacija;
            if (odabranaAplikacija != null)
            {
                List<Korisnicki_racun> racuniAplikacije = Korisnicki_racun.DohvatiRacune(odabranaAplikacija);
                dgvRacuni.DataSource = racuniAplikacije;
                dgvRacuni.Columns[0].Visible = false;
                dgvRacuni.Columns[3].Visible = false;
                dgvRacuni.Columns[1].HeaderText = "Korisnicko ime";
                dgvRacuni.Columns[2].HeaderText = "Lozinka";
            }
        }

        private void dgvAplikacije_SelectionChanged(object sender, EventArgs e)
        {
            Aplikacija odabranaAplikacija = dgvAplikacije.CurrentRow.DataBoundItem as Aplikacija;
            label2.Text = "Prikaz računa za aplikaciju " + odabranaAplikacija.Naziv + ":";
            OsvjeziKorRacune();
        }

        private void btnNoviRacun_Click(object sender, EventArgs e)
        {
            odabranaAplikacija = dgvAplikacije.CurrentRow.DataBoundItem as Aplikacija;
            if (odabranaAplikacija != null)
            {
                Novi_racun noviRacun = new Novi_racun(odabranaAplikacija);
                noviRacun.ShowDialog();
            }
            OsvjeziKorRacune();
        }

        private void btnObrisiRacun_Click(object sender, EventArgs e)
        {
            Korisnicki_racun odabraniRacun = dgvRacuni.CurrentRow.DataBoundItem as Korisnicki_racun;
            if (odabraniRacun != null)
            {
                odabraniRacun.ObrisiRacun();
                OsvjeziKorRacune();
            }
        }
    }
}
