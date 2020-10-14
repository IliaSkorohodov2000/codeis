using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project_org
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string user_name;
        int role;

        public void log_regular(string log)
        {
            string log_string = "[Form4][" + Convert.ToString(DateTime.Now) + "] " + log + Environment.NewLine;
            if (File.Exists("log.txt") == false) File.Create("log.txt");
            System.Threading.Thread.Sleep(100);
            File.AppendAllText("log.txt", log_string);
        }

        public void log_error(string log)
        {
            string log_string = "[Form4][" + Convert.ToString(DateTime.Now) + "] " + log + Environment.NewLine;
            if (File.Exists("error_log.txt") == false) File.Create("error_log.txt");
            System.Threading.Thread.Sleep(100);
            File.AppendAllText("error_log.txt", log_string);
        }

        public void PassValue2(int value, string user)
        {
            role = value;
            user_name = user;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("Documents") == false) Directory.CreateDirectory("Documents");
            string[] files = Directory.GetFiles("Documents", "*", SearchOption.TopDirectoryOnly);
            foreach(string s in files)
            {
                listBox1.Items.Add(s);
            }

        }

        private void backb_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form2 a = new Form2();
                a.PassValue(role, user_name);
                a.ShowDialog();
                Application.Exit();
            }
            catch (InvalidCastException ex)
            {
                log_error(ex.ToString());
            }
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    log_regular("Пользователь" + user_name + " вышел.");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No) { }
            }
            catch (InvalidCastException ex)
            {
                log_error(ex.ToString());
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string curDir = Directory.GetCurrentDirectory();
                MessageBox.Show(curDir + listBox1.SelectedItem.ToString());
                webBrowser1.Navigate(curDir + "/" + listBox1.SelectedItem.ToString());
            }
        }
    }
}
