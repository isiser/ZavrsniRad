using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratkicniDio_Zavrsni
{
    public class Korisnik
    {
        public int ID_korisnik { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Korisnik()
        {

        }

        public Korisnik(MySqlDataReader dr)
        {
            if (dr != null)
            {
                ID_korisnik = int.Parse(dr["ID_korisnik"].ToString());
                Korisnicko_ime = dr["Korisnicko_ime"].ToString();
                Ime = dr["Ime"].ToString();
                Prezime = dr["Prezime"].ToString();
            }
        }
        

        public int Registriraj()
        {
            string sqlUpit = "INSERT INTO Korisnik (Korisnicko_ime, Ime, Prezime) VALUES ('" + Korisnicko_ime 
                + "','" + Ime 
                + "','" + Prezime + "');";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int DohvatiID()
        {
            string sqlUpit = $"SELECT ID_korisnik FROM Korisnik WHERE Korisnicko_ime = '{Korisnicko_ime}'";
            int ID = (int)DB.Instance.DohvatiVrijednost(sqlUpit);
            return ID;
        }

        public static Korisnik DohvatiKorisnika(int matchID)
        {
            string sqlUpit = $"SELECT * FROM Korisnik WHERE ID_korisnik = {matchID}";
            MySqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            if (dr.Read())
            {
                Korisnik trazeniKorisnik = new Korisnik(dr);
                dr.Close();
                return trazeniKorisnik;
            }
            dr.Close();     //DataReader treba obavezno zatvoriti nakon uporabe.
            return null;
        }

        public static List<Korisnik> DohvatiSveKorisnike()
        {
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            string sqlUpit = $"SELECT * FROM Korisnik;";
            MySqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Korisnik korisnik = new Korisnik(dr);
                listaKorisnika.Add(korisnik);
            }
            dr.Close();     //DataReader treba obavezno zatvoriti nakon uporabe.
            return listaKorisnika;
        }

        public static Korisnik DohvatiKorisnikaPomocuKorime(string KorisnickoIme)
        {
            string sqlUpit = $"SELECT * FROM Korisnik WHERE Korisnicko_ime = '{KorisnickoIme}'";
            MySqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            if (dr.Read())
            {
                Korisnik trazeniKorisnik = new Korisnik(dr);
                dr.Close();
                return trazeniKorisnik;
            }
            dr.Close();     //DataReader treba obavezno zatvoriti nakon uporabe.
            return null;
        }




    }



}
