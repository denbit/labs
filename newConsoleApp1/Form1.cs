using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace newConsoleApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection c;
        MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void hide_Click(object sender, EventArgs e)
        {
           // this.Close();
            this.Hide();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Form was destroyed!");
            Console.BackgroundColor = ConsoleColor.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = db.Text;
            //database = "connectcsharptomysql";
            string uid = login.Text;
            string passwor = password.Text;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "UID=" + uid + ";" + "PASSWORD=" + passwor + ";";
            c = new MySqlConnection(connectionString);
            c.Open();
            //create command and assign the query and connection from the constructor
            string query = "show databases;";
            MySqlCommand cmd = new MySqlCommand(query, c);

            //Execute command
            MySqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                dbs.Items.Add(dt[0]);
            }
            dt.Close();
          
        }

        private void dbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.ChangeDatabase(dbs.GetItemText(dbs.SelectedItem));
           db_status.Text="DB " + dbs.GetItemText(dbs.SelectedItem) + " is selected.";
            string query = "show tables;";
            cmd = new MySqlCommand(query,c);
            cmd.CommandText = query;
            //Execute command
            MySqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                tables.Items.Add(dt[0]);
            }
        }
    }
    }
