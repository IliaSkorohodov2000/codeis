using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form5 : Form
    {
        Form6 a = new Form6();
        Form7 b = new Form7();
        Form3 c = new Form3();
        Form8 d = new Form8();

        public Form5()
        {
            InitializeComponent();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sklad_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.ShowDialog();
            Application.Exit();
        }

        private void sprav_Click(object sender, EventArgs e)
        {
            this.Hide();
            b.ShowDialog();
            Application.Exit();
        }

        private void ordersb_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.ShowDialog();
            Application.Exit();
        }

        private void bdb_Click(object sender, EventArgs e)
        {
            this.Hide();
            d.ShowDialog();
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ifrom = 5;
            Properties.Settings.Default.Save();
        }
    }
}
