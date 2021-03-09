using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratkicniDio_Zavrsni
{
    class DB
    {
        private static DB instance; //Singleton objekt
        private string connectionString; //Putanja i ostali podaci za spajanje na bazu
        private MySqlConnection connection; //Konekcija prema bazi
        public static DB Instance //Singleton instanca klase za rad za bazom.
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }
        public string ConnectionString //Putanja i ostali podaci za spajanje na bazu
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }
        public MySqlConnection Connection //Konekcija prema bazi
        {
            get { return connection; }
            private set { connection = value; }
        }        private DB() //Konstruktor klase
        {
            ConnectionString = "Server=127.0.0.1; Database= zavrsnirad; Uid=root; Pwd=dzx123mna";
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }
        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Dohvaća podatke u obliku DataReader objekta na temelju proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Rezultati upita.</returns>
        public MySqlDataReader DohvatiDataReader(string sqlUpit)
        {
            MySqlCommand command = new MySqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }
        /// <summary>
        /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Skalarna vrijednost kao rezultat upita.</returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            MySqlCommand command = new MySqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }
        /// <summary>
        /// Izvršava INSERT, UPDATE, DELETE SQL izraz.
        /// </summary>
        /// <param name="sqlUpit">INSERT, UPDATE, DELETE SQL izraz.</param>
        /// <returns>Broj redaka u tablici koji su promijenjeni.</returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            MySqlCommand command = new MySqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }


    }
}
