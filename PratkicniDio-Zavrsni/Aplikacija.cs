using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratkicniDio_Zavrsni
{
    public class Aplikacija
    {
        public int ID_aplikacija { get; set; }
        public string Naziv { get; set; }
        public int FK_korisnik { get; set; }

        public Aplikacija()
        {

        }

        public Aplikacija(MySqlDataReader dr)
        {
            if (dr != null)
            {
                ID_aplikacija = int.Parse(dr["ID_aplikacija"].ToString());
                Naziv = dr["Naziv"].ToString();
                FK_korisnik = int.Parse(dr["FK_korisnik"].ToString());
            }
        }

        public static List<Aplikacija> DohvatiAplikacije(Korisnik odabraniKorisnik)
        {
            List<Aplikacija> listaAplikacija = new List<Aplikacija>();
            string sqlUpit = $"SELECT * FROM Aplikacija WHERE FK_korisnik= {odabraniKorisnik.ID_korisnik}";
            MySqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Aplikacija aplikacija = new Aplikacija(dr);
                listaAplikacija.Add(aplikacija);
            }
            dr.Close();     //DataReader treba obavezno zatvoriti nakon uporabe.
            return listaAplikacija;
        }

        public int DodajAplikaciju()
        {
           string sqlUpit = $"INSERT INTO Aplikacija (Naziv, FK_korisnik) VALUES ('{Naziv}', '{FK_korisnik}')";
           return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int ObrisiAplikaciju()
        {
            string sqlDelete = "DELETE FROM Aplikacija WHERE ID_aplikacija = " + ID_aplikacija;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }
    }
}
