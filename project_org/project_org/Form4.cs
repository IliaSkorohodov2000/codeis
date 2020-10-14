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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string S1, S2;
        List<string> names = new List<string>();
        List<string> types = new List<string>();
        int array_length = 0;
        string global_table;
        int global_id;
        string user;

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

        List<Tuple<int, int>> label_location = new List<Tuple<int, int>>
        {
            new Tuple<int,int>(42, 43),
            new Tuple<int,int>(42, 80),
            new Tuple<int,int>(42, 117),
            new Tuple<int,int>(42, 154),
            new Tuple<int,int>(42, 191),
            new Tuple<int,int>(388, 43),
            new Tuple<int,int>(388, 80),
            new Tuple<int,int>(388, 117),
            new Tuple<int,int>(388, 154),
            new Tuple<int,int>(388, 191),
            new Tuple<int,int>(734, 43),
            new Tuple<int,int>(734, 80),
            new Tuple<int,int>(734, 117),
            new Tuple<int,int>(734, 154),
            new Tuple<int,int>(734, 191)
        };

        /*      List<Tuple<int, int>> object_location = new List<Tuple<int, int>>
              {
                  new Tuple<int,int>(111, 43),
                  new Tuple<int,int>(111, 80),
                  new Tuple<int,int>(111, 117),
                  new Tuple<int,int>(111, 154),
                  new Tuple<int,int>(111, 191),
                  new Tuple<int,int>(457, 43),
                  new Tuple<int,int>(457, 80),
                  new Tuple<int,int>(457, 117),
                  new Tuple<int,int>(457, 154),
                  new Tuple<int,int>(457, 191),
                  new Tuple<int,int>(803, 43),
                  new Tuple<int,int>(803, 80),
                  new Tuple<int,int>(803, 117),
                  new Tuple<int,int>(803, 154),
                  new Tuple<int,int>(803, 191)
              };*/

        List<Tuple<int, int>> object_location = new List<Tuple<int, int>>
        {
            new Tuple<int,int>(111 + 50, 43),
            new Tuple<int,int>(111 + 50, 80),
            new Tuple<int,int>(111 + 50, 117),
            new Tuple<int,int>(111 + 50, 154),
            new Tuple<int,int>(111 + 50, 191),
            new Tuple<int,int>(457 + 50, 43),
            new Tuple<int,int>(457 + 50, 80),
            new Tuple<int,int>(457 + 50, 117),
            new Tuple<int,int>(457 + 50, 154),
            new Tuple<int,int>(457 + 50, 191),
            new Tuple<int,int>(803 + 50, 43),
            new Tuple<int,int>(803 + 50, 80),
            new Tuple<int,int>(803 + 50, 117),
            new Tuple<int,int>(803 + 50, 154),
            new Tuple<int,int>(803 + 50, 191)
        };

        public void PassValue3(int mode, string table, int id, string user_name)
        {
            try
            {
                if (mode == 1)
                {
                    Table_add(mode, table);
                    button1.Text = "Добавить";
                }
                else
                {
                    Table_edit(mode, table, id);
                    button1.Text = "Изменить";
                    global_id = id;
                }
                global_table = table;
                user = user_name;
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        public void Create_form(string table, int id)
        {
            try
            {
                IDictionary<string, string> dict = Get_Columns(table);
                int i = 0;

                int[] position = new int[100];
                int b = 0;
                while (i < 30)
                {
                    string obj_array = label_location[b].ToString();
                    b++;
                    obj_array = obj_array.Replace('(', ' ');
                    obj_array = obj_array.Replace(')', ' ');
                    position[i] = Convert.ToInt32(obj_array.Split(',')[0].Trim());
                    position[i + 1] = Convert.ToInt32(obj_array.Split(',')[1].Trim());
                    i = i + 2;
                    if (position[i] == 734 && position[i + 1] == 191)
                    {
                        continue;
                    }
                }
                int c = 0;
                for (int f = 0; c < names.Count(); f = f + 2)
                {
                    Label test = new Label();
                    test.Text = names[c];
                    c++;
                    this.Controls.Add(test);
                    test.Location = new Point(position[f], position[f + 1]);
                    test.Name = "label" + f.ToString();
                }
                int d = 0;
                i = 0;
                b = 0;
                while (i < 30)
                {
                    string obj_array = object_location[b].ToString();
                    b++;
                    obj_array = obj_array.Replace('(', ' ');
                    obj_array = obj_array.Replace(')', ' ');
                    position[i] = Convert.ToInt32(obj_array.Split(',')[0].Trim());
                    position[i + 1] = Convert.ToInt32(obj_array.Split(',')[1].Trim());
                    i = i + 2;
                    if (position[i] == 803 && position[i + 1] == 191)
                    {
                        continue;
                    }
                }
                int a = 0;
                foreach (string s in types)
                {
                    switch (s)
                    {
                        case "int":
                            NumericUpDown test = new NumericUpDown();
                            this.Controls.Add(test);
                            if (id > 0)
                            {
                                string[] value = Sql_Read(table, "SELECT " + names[d] + " FROM dbo.projectorg_" + table + " WHERE " + names[0] + " = " + id + ";");
                                test.Value = Convert.ToInt32(value[0]);
                            }
                            test.Location = new Point(position[a], position[a + 1]);
                            test.Maximum = 100000000000;
                            a = a + 2;
                            test.Name = d.ToString();
                            d++;
                            break;
                        case "char":
                            TextBox test2 = new TextBox();
                            this.Controls.Add(test2);
                            if (id != 0)
                            {
                                string[] value = Sql_Read(table, "SELECT " + names[d] + " FROM dbo.projectorg_" + table + " WHERE " + names[0] + " = " + id + ";");
                                test2.Text = value[0];
                            }
                            test2.Location = new Point(position[a], position[a + 1]);
                            a = a + 2;
                            test2.Name = d.ToString();
                            d++;
                            break;
                        case "datetime":
                            DateTimePicker test3 = new DateTimePicker();
                            this.Controls.Add(test3);
                            if (id != 0)
                            {
                                string[] value = Sql_Read(table, "SELECT " + names[d] + " FROM dbo.projectorg_" + table + " WHERE " + names[0] + " = " + id + ";");
                                test3.Value = Convert.ToDateTime(value[0]);
                            }
                            test3.Location = new Point(position[a], position[a + 1]);
                            a = a + 2;
                            test3.Name = d.ToString();
                            d++;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        public void Table_add(int mode, string table)
        {
            Create_form(table, 0);
        }

        public void Table_edit(int mode, string table, int id)
        {
            Create_form(table, id);
        }

        public string[] Sql_Read(string table, string sql_command)
        {
            try
            {
                string connection_string = "Data Source=SQL001;Initial Catalog=LearnDB;Integrated Security=True";
                //string connection_string = "Data Source=localhost;Initial Catalog=LEARNDB;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    String sql = sql_command;
                    int i = 0;
                    string[] result = new string[100];
                    array_length = 0;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result[i] = reader.GetValue(0).ToString();
                                i++;
                                array_length++;
                            }
                            connection.Close();
                        }
                        return result;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string command_sql = "";
                int g = 0;
                int mode = 0;
                if (button1.Text == "Добавить")
                {
                    command_sql += "INSERT INTO dbo.projectorg_" + global_table + " VALUES(";
                    mode = 1;
                }
                else
                {
                    command_sql += "UPDATE dbo.projectorg_" + global_table + " SET ";
                    mode = 2;
                }
                foreach (Control o in this.Controls)
                {
                    if (o is NumericUpDown)
                    {
                        if (mode == 1) command_sql += ((NumericUpDown)o).Value + ",";
                        if (mode == 2) command_sql += names[g] + " = " + ((NumericUpDown)o).Value + ",";
                        g++;
                    }
                    if (o is TextBox)
                    {
                        if (((TextBox)o).Text != "")
                        {
                            if (mode == 1) command_sql += "'" + ((TextBox)o).Text + "',";
                            if (mode == 2) command_sql += names[g] + " = '" + ((TextBox)o).Text + "',";
                            g++;
                        }
                        else
                        {
                            MessageBox.Show("Найдено не заполненное поле с текстовым значением.");
                        }


                        if (o is DateTimePicker)
                        {
                            if (mode == 1) command_sql += "'" + ((DateTimePicker)o).Value + "',";
                            if (mode == 2) command_sql += names[g] + " = '" + ((DateTimePicker)o).Value + "',";
                            g++;
                        }

                    }
                    if (mode == 1)
                    {
                        command_sql = command_sql.Remove(command_sql.Length - 1, 1) + ");";
                    }
                    else
                    {
                        command_sql = command_sql.Remove(command_sql.Length - 1, 1) + " WHERE " + names[0] + " = " + global_id + ";";
                    }
                    //string connection_string = "Data Source=localhost;Initial Catalog=LEARNDB;Integrated Security=True";
                    string connection_string = "Data Source=SQL001;Initial Catalog=LearnDB;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connection_string))
                    {
                        using (SqlCommand command = new SqlCommand(command_sql, connection))
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Манипуляции произведены");
                    log_regular("User:" + user + " command: " + command_sql);
                }
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
                MessageBox.Show("Ошибка подключения к серверу SQL, проверьте доступность сервера и таблиц.");
            }
        }

        public IDictionary<string, string> Get_Columns(string table)
        {
            try
            {
                string[] column_names = Sql_Read(table, "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'projectorg_" + table + "';");
                string[] column_types = Sql_Read(table, "select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'projectorg_" + table + "';");
                IDictionary<string, string> dict = new Dictionary<string, string>();
                for (int i = 0; i < array_length; i++)
                {
                    dict.Add(column_names[i], column_types[i]);
                    names.Add(column_names[i]);
                    types.Add(column_types[i]);
                }
                return dict;
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
                MessageBox.Show("Ошибка подключения к серверу SQL, проверьте доступность сервера и таблиц.");
                return null;
            }
        }
    }
}
