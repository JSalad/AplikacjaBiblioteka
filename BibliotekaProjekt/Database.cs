using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BibliotekaProjekt
{
    class Database
    {
        private string host = "mariadb106.server640683.nazwa.pl";
        private string user = "server640683_saladiak";
        private string password = "_6YX4dMP@_95c7Q";
        private string name = "server640683_saladiak";

        private MySqlConnection sqlCon = new MySqlConnection();
        private MySqlCommand sqlCmd = new MySqlCommand();
        private DataTable sqlDt = new DataTable();
        private MySqlDataReader sqlReader;

        public DataTable Query(string query, IDictionary Parameters)
        {

            try
            {
                sqlCon.ConnectionString = "Server=" + host + "; Database=" + name + "; Uid=" + user + ";" + "Pwd=" + password + ";";
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = query;
                foreach (DictionaryEntry data in Parameters)
                {
                    sqlCmd.Parameters.AddWithValue("@" + data.Key, data.Value);
                }

                sqlReader = sqlCmd.ExecuteReader();
                sqlDt.Load(sqlReader);
                sqlReader.Close();
                sqlCon.Close();

                return sqlDt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public MySqlDataReader Query2(string query, IDictionary Parameters)
        {

            try
            {
                sqlCon.ConnectionString = "Server=" + host + "; Database=" + name + "; Uid=" + user + ";" + "Pwd=" + password + "; convert zero datetime=True";
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = query;
                foreach (DictionaryEntry data in Parameters)
                {
                    sqlCmd.Parameters.AddWithValue("@" + data.Key, data.Value);
                }

                sqlReader = sqlCmd.ExecuteReader();
                return sqlReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public int Exec(string query, IDictionary Parameters)
        {

            try
            {
                sqlCon.ConnectionString = "server=" + host + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + name;
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = query;
                foreach (DictionaryEntry data in Parameters)
                {
                    sqlCmd.Parameters.AddWithValue("@" + data.Key, data.Value);
                }
                int rows_affected = sqlCmd.ExecuteNonQuery();
                sqlCon.Close();


                return rows_affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        public void Close()
        {
            try
            {
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ~Database()
        {
        }

    }
}
