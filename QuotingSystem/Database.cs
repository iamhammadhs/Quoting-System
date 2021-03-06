using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuotingSystem
{
    class Database
    {
        string MySqlConnectionString;
        MySqlConnection databaseConnection;
        MySqlDataAdapter dataAdapter;
        public void open()
        {
            try
            {
                MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=quotingsystem";
                databaseConnection = new MySqlConnection(MySqlConnectionString);
                databaseConnection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

        }
        public DataTable searchquery(string q)
        {
            DataTable dt = new DataTable();
            try
            {
                dataAdapter = new MySqlDataAdapter(q, databaseConnection);
                dataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            return dt;
        }
        public bool insertquery(string q)
        {
            try
            {
                MySqlCommand smd = new MySqlCommand(q, databaseConnection);
                int flag = smd.ExecuteNonQuery();
                if (flag > 0)
                    return true;
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            return false;
        }
        public bool updatequery(string q)
        {
            try
            {
                MySqlCommand smd = new MySqlCommand(q, databaseConnection);
                int flag = smd.ExecuteNonQuery();
                if (flag > 0)
                    return true;
                else return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            return false;
        }
        public void close()
        {
            databaseConnection.Close();
        }
    }
}

