using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;

namespace app
{
    public class dbImp
    {
        SqlConnection connection;
        string connectionString;

        int Jaar;
        string Naam;
        public dbImp(string name, int jaar)
        {
            this.Naam = name;
            this.Jaar = jaar;
            //InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["app.Properties.Settings.dbConnectionString"].ConnectionString;
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

               /* Location.Name = "wijk_naam";
                Location.WOZ = "woz_waarde";
                Location.Datasource = wijkTable;
                */
            }
        }
        private string WOZ_db()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT woz_waarde FROM Wijk", connection))
            {
                DataTable wijkTable = new DataTable();
                adapter.Fill(wijkTable);
                int WOZ = wijkTable;
            }
            
            return WOZ;
        }
        //public void listTables_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(listTables.SelectValue.ToString());
        //}
    }
}
