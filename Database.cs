using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public class Database
    {
        private string ConnectionString = "User ID=postgres;Password=pass;Host=localhost;Port=5432;Database=postgres;Pooling=true;";

        private NpgsqlConnection Connect()
        {
            NpgsqlConnection con = new NpgsqlConnection(this.ConnectionString);
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                return con;
            }
            catch
            {
                MessageBox.Show("Bağlantı hatası oluştu.");
                return null;
            }
        }

        /// <summary>
        /// SELECT ile ilgili işlemlerini yapıp Tablo döndüren method
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable GetTable(string query)
        {
            try
            {
                var con = Connect();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Veri Adaptörü  tablo hatası oluştu.");
                return null;
            }
        }
 

    public DataTable GetFunctionTable(string query)
        {
            try
            {
                var con = Connect();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];

            }
            catch
            {
                MessageBox.Show("Veri Adaptörü  tablo hatası oluştu.");
                return null;
            }
        }
       /// <summary>
        /// SELECT ile ilgili işlemlerini yapan tek satır döndüren method
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataRow GetRow(string query)
        {
            try
            {
                var table = GetTable(query);
                if (table.Rows.Count > 0)
                    return table.Rows[0];
                return null;
            }
            catch
            {
                MessageBox.Show("Veri adaptörü satır hatası oluştu.");
                return null;
            }
        }

        /// <summary>
        /// INSERT, DELETE ve Update query lerini çalıştıran method
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public bool ExecuteQuery(string query)
        {
            try
            {
                var con = Connect();
                NpgsqlCommand command = new NpgsqlCommand(query, con);
                if (command.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Komut yürütme hatası oluştu.");
                return false;
            }
        }

       


    }
}
