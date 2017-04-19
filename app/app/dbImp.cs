using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic;

namespace app
{
    public class dbImp : Form2
    {
        SqlConnection connection;
        string connectionString;
        string name2;
        float WOZ;
        SqlDataReader reader;
        public string new_reader;

        int Jaar;
        string Naam;
        public dbImp()
        {

            //InitializeComponent();
            
            connectionString = ConfigurationManager.ConnectionStrings["app.Properties.Settings.dbConnectionString"].ConnectionString;
            PopulateTables();
        }

        public void dbImp_Load(object sender, EventArgs e)
        {
            PopulateTables();
        }

        public void PopulateTables()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Wijk", connection))
            {
                DataTable wijkTable = new DataTable();
                adapter.Fill(wijkTable);


                SqlDataReader reader;

                SqlCommand Name = new SqlCommand("SELECT * FROM Wijk WHERE jaartal = 2010", connection);
                Name.ExecuteReader();
                Name.Parameters.Add(name2);
                //WOZ = "woz_waarde";
                //Datasource = wijkTable;
                SqlCommand new_name = new SqlCommand("SELECT * FROM Wijk WHERE jaartal = 2010", connection);
                new_name.CommandText = "";

                new_name.Connection = connection;


                reader = new_name.ExecuteReader();
                reader.GetSqlString(1);
                new_reader = Convert.ToString(reader);
            }
        }
        public string give_reader()
        {

            return new_reader;
        }

        //private string WOZ_db()
        //{
        //    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT woz_waarde FROM Wijk", connection))
        //    {
        //        DataTable wijkTable = new DataTable();
        //        adapter.Fill(wijkTable);
        //        int WOZ = wijkTable;
        //    }

        //    return WOZ;
        //}
        //public void listTables_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(listTables.SelectValue.ToString());
        //}
    }
}
