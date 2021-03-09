using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratkicniDio_Zavrsni
{
    class Otisak_prsta
    {
        public int ID_prst { get; set; }
        public string Otisak_putanja { get; set; }
        public int FK_korisnik { get; set; }

        public Otisak_prsta()
        {

        }

        public Otisak_prsta(MySqlDataReader dr)
        {
            if (dr != null)
            {
                ID_prst = int.Parse(dr["ID_prst"].ToString());
                Otisak_putanja = dr["OtisakPutanja"].ToString();
                FK_korisnik = int.Parse(dr["FK_korisnik"].ToString());
            }
        }
        
        public int SpremiOtisak()
        {
            string sqlUpit = "INSERT INTO Otisak_prsta (OtisakPutanja, FK_korisnik) VALUES ('" + Otisak_putanja
                + "'," + FK_korisnik + ");";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<Otisak_prsta> DohvatiOtiske()
        {
            List<Otisak_prsta> listaOtisaka = new List<Otisak_prsta>();
            string sqlUpit = $"SELECT * FROM Otisak_prsta;";
            MySqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Otisak_prsta otisak_Prsta = new Otisak_prsta(dr);
                listaOtisaka.Add(otisak_Prsta);
            }
            dr.Close();     //DataReader treba obavezno zatvoriti nakon uporabe.
            return listaOtisaka;
        }
    }
}
