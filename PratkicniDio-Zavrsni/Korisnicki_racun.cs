using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratkicniDio_Zavrsni
{
    class Korisnicki_racun
    {
        public int ID_racun { get; set; }
        public string Korime { get; set; }
        public string Lozinka { get; set; }
        public int FK_aplikacija { get; set; }

        public Korisnicki_racun()
        {

        }

        public Korisnicki_racun(MySqlDataReader dr)
        {
            if (dr != null)
            {
                ID_racun = int.Parse(dr["ID_racun"].ToString());
                Korime = dr["Korime"].ToString();
                Lozinka = dr["Lozinka"].ToString();
                FK_aplikacija = int.Parse(dr["FK_aplikacija"].ToString());
            }
        }

        public static List<Korisnicki_racun> DohvatiRacune(Aplikacija aplikacijaOdabrana)
        {
            List<Korisnicki_racun> listaRacuna = new List<Korisnicki_racun>();
            string sqlUpit = $"SELECT * FROM Korisnicki_racun WHERE FK_aplikacija= {aplikacijaOdabrana.ID_aplikacija}";
            MySqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Korisnicki_racun racun = new Korisnicki_racun(dr);
                listaRacuna.Add(racun);
            }
            dr.Close();     //DataReader treba obavezno zatvoriti nakon uporabe.
            return listaRacuna;
        }

        public int DodajRacun()
        {
            string sqlUpit = $"INSERT INTO Korisnicki_racun (Korime, Lozinka, FK_aplikacija) VALUES ('{Korime}', '{Lozinka}', {FK_aplikacija})";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int ObrisiRacun()
        {
            string sqlDelete = "DELETE FROM Korisnicki_racun WHERE ID_racun = " + ID_racun;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }
    }
}
