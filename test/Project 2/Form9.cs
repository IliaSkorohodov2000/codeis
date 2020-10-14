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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ifrom = 9;
            Properties.Settings.Default.Save();
        }

        private void sklad_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            this.Hide();
            a.ShowDialog();
            Application.Exit();
        }

        private void sprav_Click(object sender, EventArgs e)
        {
            Form7 b = new Form7();
            this.Hide();
            b.ShowDialog();
            Application.Exit();
        }

        private void ordersb_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            this.Hide();
            c.ShowDialog();
            Application.Exit();
        }

        private void bdb_Click(object sender, EventArgs e)
        {
            Form8 d = new Form8();
            this.Hide();
            d.ShowDialog();
            Application.Exit();
        }

        private void usersb_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            this.Hide();
            f.ShowDialog();
            Application.Exit();
        }
    }
}
