using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Project_2
{
    public partial class Form1 : Form
    {
        Form2 a = new Form2();
        Form5 b = new Form5();
        Form9 c = new Form9();
        string curright = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void authb_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT rights FROM Users WHERE login = '" + login.Text + "' AND password = '" + password.Text + "'";
            string Connect = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Y:\\Student\\18ИПП\\ОАиП\\2 подгр\\Проект СПС\\Backup\\Project 2\\DB.accdb";
            OleDbConnection myConnection = new OleDbConnection(Connect);
            OleDbCommand myCommand = new OleDbCommand(CommandText, myConnection);
            myConnection.Open();
            OleDbDataReader datareader = myCommand.ExecuteReader();
            OleDbCommand rights = new OleDbCommand("SELECT * FROM users WHERE rights");
            while (datareader.Read())
            {
                curright = datareader.GetString(0);
            }


            if (login.Text == "root" && password.Text == "guest" || curright == "guest")
            {
                this.Hide();
                a.ShowDialog();
                Application.Exit();
            }

            if (login.Text == "root" && password.Text == "worker" || curright == "worker")
            {
                this.Hide();
                b.ShowDialog();
                Application.Exit();
            }

            if (login.Text == "root" && password.Text == "admin" || curright == "admin")
            {
                this.Hide();
                c.ShowDialog();
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ifrom = 0;
            Properties.Settings.Default.Save();
        }
    }
}
