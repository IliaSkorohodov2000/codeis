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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void backb_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Ifrom == 5)
            {
                Form5 a = new Form5();
                this.Hide();
                a.ShowDialog();
                Application.Exit();
            }

            if (Properties.Settings.Default.Ifrom == 9)
            {
                Form9 b = new Form9();
                this.Hide();
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
