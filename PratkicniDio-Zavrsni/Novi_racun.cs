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
    public partial class Novi_racun : Form
    {
        private Aplikacija aplikacija = null;

        public Novi_racun(Aplikacija aplikacijaTrenutna)
        {
            InitializeComponent();
            aplikacija = aplikacijaTrenutna;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajRacun_Click(object sender, EventArgs e)
        {
            if (aplikacija != null)
            {
                Korisnicki_racun noviRacun = new Korisnicki_racun();
                noviRacun.Korime = txtKorime.Text;
                noviRacun.Lozinka = txtLozinka.Text;
                noviRacun.FK_aplikacija = aplikacija.ID_aplikacija;
                noviRacun.DodajRacun();
            }
            Close();
        }

        private void Novi_racun_Load(object sender, EventArgs e)
        {
            if (aplikacija != null)
            {
                txtAplikacija.Text = aplikacija.Naziv;
                txtAplikacija.ReadOnly = true;
            }
        }
    }
}
