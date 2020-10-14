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
    public partial class Form2 : Form
    {
        Form3 a = new Form3();
        Form4 b = new Form4();

        public Form2()
        {
            InitializeComponent();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordersb_Click(object sender, EventArgs e)
        {
            this.Hide();
            a.ShowDialog();
            Application.Exit();
        }

        private void assortb_Click(object sender, EventArgs e)
        {
            this.Hide();
            b.ShowDialog();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ifrom = 2;
            Properties.Settings.Default.Save();
        }
    }
}
