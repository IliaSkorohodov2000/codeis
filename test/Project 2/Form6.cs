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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backb_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Ifrom == 5)
            {
                this.Hide();
                Form5 a = new Form5();
                a.ShowDialog();
                Application.Exit();
            }

            if (Properties.Settings.Default.Ifrom == 9)
            {
                this.Hide();
                Form9 b = new Form9();
                b.ShowDialog();
                Application.Exit();
            }
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No) { }
        }
    }
}
