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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string table = "employers";
        int form_value;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        string user;

        public void log_regular(string log)
        {
            string log_string = "[Form3][" + Convert.ToString(DateTime.Now) + "] " + log + Environment.NewLine;
            if (File.Exists("log.txt") == false) File.Create("log.txt");
            System.Threading.Thread.Sleep(100);
            File.AppendAllText("log.txt", log_string);

        }

        public void log_error(string log)
        {
            string log_string = "[Form3][" + Convert.ToString(DateTime.Now) + "] " + log + Environment.NewLine;
            if (File.Exists("error_log.txt") == false) File.Create("error_log.txt");
            System.Threading.Thread.Sleep(100);
            File.AppendAllText("error_log.txt", log_string);
        }


        public string Execute_Sql(string sql_command)
        {
            try
            {
                string connection_string = "Data Source=SQL001;Initial Catalog=LearnDB;Integrated Security=True";
                //string connection_string = "Data Source=localhost;Initial Catalog=LEARNDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    String sql = sql_command;
                    List<string> result = new List<string>();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        log_regular("User:" + user + ", command: " + sql);
                    }
                }
                return connection_string;
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
                MessageBox.Show("Ошибка подключения к серверу SQL, проверьте доступность сервера и таблиц.");
                return null;
            }
        }

        public void Fill_datagrid()
        {
            try
            {
                string connection_string = "Data Source=SQL001;Initial Catalog=LearnDB;Integrated Security=True";
                //string connection_string = "Data Source=localhost;Initial Catalog=LEARNDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    String sql = "SELECT * FROM dbo.projectorg_" + table;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        adapter = new SqlDataAdapter(sql, connection);
                        adapter.Fill(ds);
                        connection.Close();
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
                MessageBox.Show("Ошибка подключения к серверу SQL, проверьте доступность сервера и таблиц.");
            }
        }

        public void PassValue2(string obj_text, int value, string user_name)
        {
            try
            {
                form_value = value;
                label1.Text = obj_text;
                user = user_name;
                switch (obj_text)
                {
                    case "Сотрудники":
                        table = "employers";
                        break;
                    case "Заказчики":
                        table = "customers";
                        break;
                    case "Заказы":
                        table = "contracts";
                        break;
                    case "Проекты":
                        table = "projects";
                        break;
                    case "Отделы":
                        table = "departments";
                        break;
                    case "Оборудование":
                        table = "equipment";
                        break;
                    case "Статусы":
                        table = "statuses";
                        break;
                    case "Принадлежность статусов":
                        table = "ownership";
                        break;
                    case "Пользователи":
                        table = "users";
                        break;
                    case "Роли пользователей":
                        table = "roles";
                        break;
                    case "Работа над проектом":
                        table = "workonproject";
                        break;
                }
                Fill_datagrid();
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }

            //dataGridView1.DataSource = learnDBDataSet.projectorg_contracts;
            /*switch (table)
            {
                case "employers":
                    this.projectorg_employersTableAdapter1.Fill(this.learnDBDataSet.projectorg_employers);
                    dataGridView1.DataSource = projectorgemployersBindingSource;
                    break;
                case "customers":
                    this.projectorg_customersTableAdapter1.Fill(this.learnDBDataSet.projectorg_customers);
                    dataGridView1.DataSource = projectorgcustomersBindingSource;
                    break;
                case "contracts":
                    this.projectorg_contractsTableAdapter1.Fill(this.learnDBDataSet.projectorg_contracts);
                    dataGridView1.DataSource = projectorgcontractsBindingSource;
                    break;
                case "projects":
                    this.projectorg_projectsTableAdapter1.Fill(this.learnDBDataSet.projectorg_projects);
                    dataGridView1.DataSource = projectorgprojectsBindingSource;
                    break;
                case "departments":
                    this.projectorg_departmentsTableAdapter1.Fill(this.learnDBDataSet.projectorg_departments);
                    dataGridView1.DataSource = projectorgdepartmentsBindingSource;
                    break;
                case "equipment":
                    this.projectorg_equipmentTableAdapter1.Fill(this.learnDBDataSet.projectorg_equipment);
                    dataGridView1.DataSource = projectorgequipmentBindingSource;
                    break;
                case "statuses":
                    this.projectorg_statusesTableAdapter1.Fill(this.learnDBDataSet.projectorg_statuses);
                    dataGridView1.DataSource = projectorgstatusesBindingSource;
                    break;
                case "ownership":
                    this.projectorg_ownershipTableAdapter1.Fill(this.learnDBDataSet.projectorg_ownership);
                    dataGridView1.DataSource = projectorgownershipBindingSource;
                    break;
                case "users":
                    this.projectorg_usersTableAdapter1.Fill(this.learnDBDataSet.projectorg_users);
                    dataGridView1.DataSource = projectorgusersBindingSource;
                    break;
                case "roles":
                    this.projectorg_rolesTableAdapter1.Fill(this.learnDBDataSet.projectorg_roles);
                    break;
                case "workonproject":
                    this.projectorg_workonprojectTableAdapter1.Fill(this.learnDBDataSet.projectorg_workonproject);
                    break;
            }*/

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void backb_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form2 a = new Form2();
                a.PassValue(form_value, user);
                a.ShowDialog();
                Application.Exit();
            }
            catch (Exception ex)
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
                    log_regular("Пользователь" + user + " вышел.");
                    this.Close();
                }
                else if (dialogResult == DialogResult.No) { }
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int del_count = 0;
                    foreach (DataGridViewRow a in dataGridView1.SelectedRows)
                    {
                        Execute_Sql("Delete FROM dbo.projectorg_" + table + " WHERE " + dataGridView1.Columns[0].Name + " = " + dataGridView1.Rows[a.Index].Cells[0].Value + ";");
                        del_count++;
                    }
                    MessageBox.Show("Удалено " + del_count + " записей.");
                }
                else MessageBox.Show("Выберите хотя бы одну запись.");
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
                MessageBox.Show("Ошибка удаления.");
            }
        }

        private void addb_Click(object sender, EventArgs e)
        {
            to_form4(1, 0);
        }

        private void editb_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    to_form4(2, Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
                }
                else MessageBox.Show("Необходимо выбрать одну запись для изменения.");
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        public void to_form4(int mode, int id)
        {
            try {
                Form4 a = new Form4();
                a.PassValue3(mode, table, id, user);
                a.ShowDialog();
            }
            catch (Exception ex)
            {
                log_error(ex.ToString());
            }
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ds.Clear();
            dataGridView1.SelectAll();
            dataGridView1.ClearSelection();
            dataGridView1.Columns.Clear();
            Fill_datagrid();
        }

        private void findb_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(search.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}

