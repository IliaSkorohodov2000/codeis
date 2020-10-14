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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void log_regular(string log)
        {
            string log_string = "[Form1][" + Convert.ToString(DateTime.Now) + "] " + log + Environment.NewLine;
            if (File.Exists("log.txt") == false) File.Create("log.txt");
            System.Threading.Thread.Sleep(100);
            File.AppendAllText("log.txt", log_string);

        }

        public void log_error(string log)
        {
            string log_string = "[Form1][" + Convert.ToString(DateTime.Now) + "] " + log + Environment.NewLine;
            if (File.Exists("error_log.txt") == false) File.Create("error_log.txt");
            System.Threading.Thread.Sleep(100);
            File.AppendAllText("error_log.txt", log_string);
        }

        public int Check_input(List<string> input)
        {
            try
            {
                int input_limit = 50;
                if (input[0].Length < input_limit && input[1].Length < input_limit)
                {
                    return 1;
                }
                else
                {
                    MessageBox.Show("Неверный формат");
                    log_regular("Превышение колличества символов при попытке авторизации");
                    return 0;
                }
            }
            catch (InvalidCastException ex)
            {
                log_error(ex.ToString());
                return 0;
            }
        }

        public int Check_user(List<string> input)
        {
            try
            {
                string connection_string = "Data Source=SQL001;Initial Catalog=LearnDB;Integrated Security=True";
                //string connection_string = "Data Source=localhost;Initial Catalog=LEARNDB;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * ");
                    sb.Append("FROM [dbo].[projectorg_users]");
                    sb.Append("WHERE user_login = '" + loginbox.Text + "' AND user_password = '" + passwordbox.Text + "';");
                    String sql = sb.ToString();
                    String role = null;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                role = reader["user_role"].ToString();
                            }
                            connection.Close();
                            if (role != null) return Convert.ToInt32(role);
                            else return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
                MessageBox.Show("Ошибка соединения с SQL, проверьте доступность сервера и таблиц.");
                return 0;
            }
        }


        private void Authorize_Click(object sender, EventArgs e)
        {
            try {
                List<string> input = new List<string>() { loginbox.Text, passwordbox.Text };
                int check1 = Check_input(input);
                if (check1 == 1)
                {
                    int check2 = Check_user(input);
                    if (check2 >= 1)
                    {
                        log_regular("Успешная авторизация. Логин: " + loginbox.Text + ".");
                        Form2 f2 = new Form2();
                        f2.PassValue(check2, loginbox.Text);
                        this.Hide();
                        f2.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль.");
                        log_regular("Попытка входа под логином: " + loginbox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
                MessageBox.Show("Ошибка авторизации.");
            }
        }
    }
}
