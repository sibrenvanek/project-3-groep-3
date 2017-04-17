﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;


namespace app
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "Rotterdamsewijken";
            uid = "username";
            password = "projectgroep3";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("connection opened");
                
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                MessageBox.Show("connection not opened");
                return false;
            }
        }
        //Close connection
        private bool CloseConnection()
        {
            try
            {
                MessageBox.Show("connection closed");
               // Interaction.InputBox("test");
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //Insert statement
        public void Insert(string query)
        {
            if (this.OpenConnection())
            {
                MessageBox.Show("hi");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<string>[] Select()
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("Select * FROM Wijk", connection);
                MessageBox.Show(Convert.ToString(cmd.ExecuteNonQuery()));
                CloseConnection();
            }
            return null;
        }

        //Count statement
        public int Count()
        {
            throw new NotImplementedException();
        }

        //Backup
        public void Backup()
        {
            throw new NotImplementedException();
        }

        //Restore
        public void Restore()
        {
            throw new NotImplementedException();
        }
    }
}