using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratkicniDio_Zavrsni
{
    class Uzorak_lica
    {
        public int ID_lica { get; set; }
        public string LicePutanja { get; set; }
        public int FK_korisnik { get; set; }

        public Uzorak_lica()
        {

        }

        public Uzorak_lica(MySqlDataReader dr)
        {
            if (dr != null)
            {
                ID_lica = int.Parse(dr["ID_lica"].ToString());
                LicePutanja = dr["LicePutanja"].ToString();
                FK_korisnik = int.Parse(dr["FK_korisnik"].ToString());
            }
        }

        public int SpremiUzorak()
        {
            string sqlUpit = "INSERT INTO Uzorak_lica (LicePutanja, FK_korisnik) VALUES ('" + LicePutanja
                + "'," + FK_korisnik + ");";
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public static List<Uzorak_lica> DohvatiUzorke()
        {
            List<Uzorak_lica> listaUzoraka = new List<Uzorak_lica>();
            string sqlUpit = $"SELECT * FROM Uzorak_lica;";
            MySqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Uzorak_lica uzorakLica = new Uzorak_lica(dr);
                listaUzoraka.Add(uzorakLica);
            }
            dr.Close();     //DataReader treba obavezno zatvoriti nakon uporabe.
            return listaUzoraka;
        }

    }
}
