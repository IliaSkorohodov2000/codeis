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
using System.IO;

namespace project_org
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int form_value;
        string user;

        public void log_regular(string log)
        {
            string log_string = "[Form2][" + Convert.ToString(DateTime.Now) + "] " + log + Environment.NewLine;
            if (File.Exists("log.txt") == false) File.Create("log.txt");
            System.Threading.Thread.Sleep(100);
            File.AppendAllText("log.txt", log_string);

        }

        public void log_error(string log)
        {
            string log_string = "[Form2][" + Convert.ToString(DateTime.Now) + "] " + log + Environment.NewLine;
            if (File.Exists("error_log.txt") == false) File.Create("error_log.txt");
            System.Threading.Thread.Sleep(100);
            File.AppendAllText("error_log.txt", log_string);
        }

        public List<string> Get_Sql(string sql_command)
        {
            try
            {
                string connection_string = "Data Source=SQL001;Initial Catalog=LearnDB;Integrated Security=True";
                //string connection_string = "Data Source=localhost;Initial Catalog=LEARNDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    String sql = sql_command;
                    List<string> result = new List<string>();
                    int i = 0;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(reader[i].ToString());
                                i++;
                            }
                            connection.Close();
                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
                MessageBox.Show("Ошибка подключения к серверу SQL, проверьте доступность сервера и таблиц.");
                return null;
            }
        }

        public void Change_title(int value)
        {
            try
            {
                List<string> result = Get_Sql("SELECT role_name from dbo.projectorg_roles WHERE N_role = " + value + ";");
                this.Text = result[0];
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        public void Generate_form(int value)
        {
            try
            {
                switch (value)
                {
                    case 1:
                        this.Size = new Size(334, 489);
                        bexit.Location = new Point(95, 389);
                        bform1.Text = "Сотрудники";
                        bform2.Text = "Заказы";
                        bform3.Text = "Проекты";
                        bform4.Text = "Отделы";
                        bform5.Text = "Оборудование";
                        bform6.Text = "Работа над проектом";
                        break;
                    case 2:
                        this.Size = new Size(334, 489);
                        bexit.Location = new Point(95, 389);
                        bform1.Text = "Сотрудники";
                        bform2.Text = "Заказы";
                        bform3.Text = "Проекты";
                        bform4.Text = "Отделы";
                        bform5.Text = "Оборудование";
                        bform6.Text = "Работа над проектом";
                        break;
                    case 3:
                        //this.Size = 369; 489;
                        foreach (var b in this.Controls.OfType<Button>())
                        {
                            b.Visible = true;
                            b.Enabled = true;
                        }
                        bform1.Text = "Сотрудники";
                        bform7.Text = "Заказчики";
                        bform2.Text = "Заказы";
                        bform8.Text = "Проекты";
                        bform3.Text = "Отделы";
                        bform9.Text = "Оборудование";
                        bform4.Text = "Статусы";
                        bform10.Text = "Принадлежность статусов";
                        bform5.Text = "Пользователи";
                        bform11.Text = "Роли пользователей";
                        bform6.Text = "Работа над проектом";
                        bform12.Text = "Документация";
                        break;
                }
                this.MaximumSize = this.Size;
                this.MinimumSize = this.Size;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        public void PassValue(int value, string user_name)
        {
            try
            {
                Change_title(value);
                Generate_form(value);
                form_value = value;
                user = user_name;
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    log_regular("Пользователь " + user + " вышел.");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No) { }
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        public void Button_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                string obj_text = Convert.ToString(sender).Substring(35);
                if(obj_text == "Документация")
                {
                    Form5 f5 = new Form5();
                    f5.PassValue2(form_value, user);
                    this.Hide();
                    f5.ShowDialog();
                    Application.Exit();
                }
                log_regular("Пользователь " + user + " перешел на форму " + obj_text + ".");
                Form3 f3 = new Form3();
                f3.PassValue2(obj_text, form_value, user);
                this.Hide();
                f3.ShowDialog();
                Application.Exit();
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }
    }
}
