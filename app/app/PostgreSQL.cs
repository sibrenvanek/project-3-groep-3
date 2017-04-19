using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace app
{
    public class PostGreSQL
    {
        public void PostgreSQL()
        {
        }
        public static string Select(string query)
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id = postgres; Password=schijt123; Database=Rotterdamsewijken;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                string returnValue = dataReader.GetString(0);
                connection.Close();
                return returnValue;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }
    }
}