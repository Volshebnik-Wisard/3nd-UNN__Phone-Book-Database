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
using System.Data;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectTab(0);
        }

       //string connection = "Data Source=192.168.9.5;User ID=sa;Password=sa";
        string connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Управление данными\Database (1-ая форма (+поиск),+) 06.04.2023\Database\Database1.mdf;Integrated Security=True";
        private void RefreshDGV(int index)
        {
            string SQLRequest = "SELECT * FROM [Order]";
            switch (index)
            {
                case 0: SQLRequest = "SELECT * FROM [Guschin_abonent]"; break;
                case 1: SQLRequest = "SELECT * FROM [Guschin_contact] JOIN [Guschin_provider] ON [Guschin_contact].provider_id = [Guschin_provider].Id"; break;
                case 2: SQLRequest = "SELECT * FROM [Guschin_provider]"; break;
                case 3:
                    SQLRequest = "SELECT * FROM [Guschin_abonent]";
                    SQLRequest += " JOIN [Guschin_abonent_has_contact] ON [Guschin_abonent].Id = [Guschin_abonent_has_contact].abonent_id";
                    SQLRequest += " JOIN [Guschin_contact] ON [Guschin_abonent_has_contact].contact_id = [Guschin_contact].Id";
                    SQLRequest += " JOIN [Guschin_provider] ON [Guschin_contact].provider_id = [Guschin_provider].Id";
                    break;
            }

            //Создаем объект адаптера
            SqlDataAdapter adapter = new SqlDataAdapter(SQLRequest, connection);

            //Создаем объект-таблицу
            DataTable dataTable = new DataTable();

            //Заполняем таблицу посредством адаптера
            adapter.Fill(dataTable);

            DataGridView dgv = new DataGridView();

            switch (index)
            {
                case 0: dgv = dataGridView1; break;
                case 1: dgv = dataGridView2; break;
                case 2: dgv = dataGridView3; break;
                case 3: dgv = dataGridView4; break;
            }

            dgv.DataSource = dataTable;

            switch (index)
            {
                case 0:
                    dgv.Columns["Id"].Visible = false;
                    dgv.Columns["surname"].HeaderText = "Фамилия";
                    dgv.Columns["name"].HeaderText = "Имя";
                    dgv.Columns["patronymic"].HeaderText = "Отчество";
                    dgv.Columns["address"].HeaderText = "Адрес";
                    dgv.Columns["birth_date"].HeaderText = "Дата рождения";
                    dgv.Columns["comment"].HeaderText = "Комментарий";
                    break;
                case 1:
                    dgv.Columns["Id"].Visible = false;
                    dgv.Columns["Id1"].Visible = false;
                    dgv.Columns["provider_id"].Visible = false;
                    dgv.Columns["score"].Visible = false;
                    dgv.Columns["phone"].HeaderText = "Номер телефона";
                    dgv.Columns["type"].HeaderText = "Тип";
                    dgv.Columns["name"].HeaderText = "Название провайдера";
                    break;
                case 2:
                    dgv.Columns["Id"].Visible = false;
                    dgv.Columns["name"].HeaderText = "Название провайдера";
                    dgv.Columns["score"].HeaderText = "Рейтинг";
                    break;
                case 3:
                    dgv.Columns["Id"].Visible = false;
                    dgv.Columns["Id1"].Visible = false;
                    dgv.Columns["Id2"].Visible = false;
                    dgv.Columns["contact_id"].Visible = false;
                    dgv.Columns["abonent_id"].Visible = false;
                    dgv.Columns["provider_id"].Visible = false;
                    dgv.Columns["score"].Visible = false;
                    dgv.Columns["surname"].HeaderText = "Фамилия";
                    dgv.Columns["name"].HeaderText = "Имя";
                    dgv.Columns["patronymic"].HeaderText = "Отчество";
                    dgv.Columns["address"].HeaderText = "Адрес";
                    dgv.Columns["birth_date"].HeaderText = "Дата рождения";
                    dgv.Columns["comment"].HeaderText = "Комментарий";
                    dgv.Columns["phone"].HeaderText = "Номер телефона";
                    dgv.Columns["type"].HeaderText = "Тип";
                    dgv.Columns["name1"].HeaderText = "Название провайдера";
                    dgv.Columns["score"].HeaderText = "Рейтинг";
                    break;
            }


            dgv.Show();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            RefreshDGV(e.TabPageIndex);
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            AbonentAddForm f = new AbonentAddForm();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string SQLRequest = "";


                SQLRequest += "INSERT INTO [Guschin_abonent] (surname,name,patronymic,address,birth_date)";
                SQLRequest += "VALUES ('" + f.surname + "','" + f.name + "','" + f.patronymic + "','" + f.address + "','" + f.birth_date.ToString("yyyy-MM-dd") + "')";

                ExecuteRequest(SQLRequest);
            }

            RefreshDGV(0);
        }

        private void buttonChange1_Click(object sender, EventArgs e)
        {
            AbonentAddForm f = new AbonentAddForm();

            var dgv = dataGridView1;
            var selected = dgv.SelectedRows;

            if (selected.Count == 0) { MessageBox.Show("Не выбрана строка."); return; }
            else if (selected.Count > 1) { MessageBox.Show("Выбрано больше одной строки."); return; };
            int abonentID = (int)dgv["Id", selected[0].Index].Value;

            f.surname = selected[0].Cells[1].Value.ToString();
            f.name = selected[0].Cells[2].Value.ToString();
            f.patronymic = selected[0].Cells[3].Value.ToString();
            f.address = selected[0].Cells[4].Value.ToString();
            f.birth_date = DateTime.Parse(selected[0].Cells[5].Value.ToString());


            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string SQLRequest = "";

                SQLRequest += "UPDATE [Guschin_abonent] ";
                SQLRequest += "SET surname = '" + f.surname + "', name = '" + f.name + "', patronymic ='" + f.patronymic + "', address = '" + f.address + "', birth_date = '" + f.birth_date.ToString("yyyy-MM-dd") + "'";
                SQLRequest += "WHERE Id = " + abonentID.ToString();

                ExecuteRequest(SQLRequest);
            }

            RefreshDGV(0);

        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            var dgv = dataGridView1;
            var selected = dgv.SelectedRows;

            if (selected.Count == 0) { MessageBox.Show("Не выбрана строка."); return; }
            else if (selected.Count > 1) { MessageBox.Show("Выбрано больше одной строки."); return; };
            int abonentID = (int)dgv["Id", selected[0].Index].Value;

            string SQLRequest = "DELETE [Guschin_abonent] WHERE Id = " + abonentID.ToString();
            ExecuteRequest(SQLRequest);

            RefreshDGV(0);
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            ContactAddForm f = new ContactAddForm();


            string SQLRequest = "SELECT * FROM [Guschin_provider]";

            SqlDataAdapter adapter = new SqlDataAdapter(SQLRequest, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Управление данными\Database (1-ая форма (+поиск),+) 06.04.2023\Database\Database1.mdf;Integrated Security=True");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            var dict = new System.Collections.Generic.Dictionary<int, string>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                dict.Add((int)dataRow[0], dataRow[1].ToString());
            }
            f.ProviderData = dict;



            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string SQLRequest2 = "";

                SQLRequest2 += "INSERT INTO [Guschin_contact] (phone,type,provider_id)";
                SQLRequest2 += "VALUES ('" + f.PhoneNumber + "','" + f.PhoneType + "','" + f.Provider + "')";

                ExecuteRequest(SQLRequest2);
            }
            RefreshDGV(1);
        }

        private void buttonChange2_Click(object sender, EventArgs e)
        {
            ContactAddForm f = new ContactAddForm();


            string SQLRequest = "SELECT * FROM [Guschin_provider]";

            SqlDataAdapter adapter = new SqlDataAdapter(SQLRequest, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Управление данными\Database (1-ая форма (+поиск),+) 06.04.2023\Database\Database1.mdf;Integrated Security=True");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            var dict = new System.Collections.Generic.Dictionary<int, string>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                dict.Add((int)dataRow[0], dataRow[1].ToString());
            }
            f.ProviderData = dict;


            var dgv = dataGridView2;
            var selected = dgv.SelectedRows;

            if (selected.Count == 0) { MessageBox.Show("Не выбрана строка."); return; }
            else if (selected.Count > 1) { MessageBox.Show("Выбрано больше одной строки."); return; };
            int contactID = (int)dgv["Id", selected[0].Index].Value;

            f.PhoneNumber = selected[0].Cells["phone"].Value.ToString();
            f.PhoneType = selected[0].Cells["type"].Value.ToString();
            f.ProviderID = (int)selected[0].Cells["provider_id"].Value;

            f.ShowDialog();


            if (f.DialogResult == DialogResult.OK)
            {
                string SQLRequest2 = "";

                SQLRequest2 += "UPDATE [Guschin_contact]  ";
                SQLRequest2 += "SET phone = " + f.PhoneNumber + ", type = '" + f.PhoneType + "', provider_id = " + f.ProviderID + " ";
                SQLRequest2 += "WHERE Id = " + contactID;

                ExecuteRequest(SQLRequest2);
            }
            RefreshDGV(1);
        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            var dgv = dataGridView2;
            var selected = dgv.SelectedRows;

            if (selected.Count == 0) { MessageBox.Show("Не выбрана строка."); return; }
            else if (selected.Count > 1) { MessageBox.Show("Выбрано больше одной строки."); return; };
            int contactID = (int)dgv["Id", selected[0].Index].Value;

            string SQLRequest = "";

            SQLRequest += "DELETE [Guschin_contact] ";
            SQLRequest += "WHERE Id = " + contactID.ToString();

            ExecuteRequest(SQLRequest);


            RefreshDGV(1);
        }

        private void buttonAdd3_Click(object sender, EventArgs e)
        {
            ProviderAddForm f = new ProviderAddForm();


            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string SQLRequest = "";

                SQLRequest += "INSERT INTO [Guschin_provider] (name,score)";
                SQLRequest += "VALUES ('" + f.name + "'," + f.rate + ")";

                ExecuteRequest(SQLRequest);
            }

            RefreshDGV(2);
        }

        private void buttonChange3_Click(object sender, EventArgs e)
        {
            ProviderAddForm f = new ProviderAddForm();

            var dgv = dataGridView3;
            var selected = dgv.SelectedRows;

            if (selected.Count == 0) { MessageBox.Show("Не выбрана строка."); return; }
            else if (selected.Count > 1) { MessageBox.Show("Выбрано больше одной строки."); return; };
            int providerID = (int)dgv["Id", selected[0].Index].Value;

            f.name = selected[0].Cells["name"].Value.ToString();
            f.rate = selected[0].Cells["score"].Value.ToString();

            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string SQLRequest = "";

                SQLRequest += "UPDATE [Guschin_provider]";
                SQLRequest += "SET name = '" + f.name + "', score = " + f.rate + " ";
                SQLRequest += "WHERE Id = " + providerID;

                ExecuteRequest(SQLRequest);
            }

            RefreshDGV(2);
        }

        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            var dgv = dataGridView3;
            var selected = dgv.SelectedRows;

            if (selected.Count == 0) { MessageBox.Show("Не выбрана строка."); return; }
            else if (selected.Count > 1) { MessageBox.Show("Выбрано больше одной строки."); return; };
            int providerID = (int)dgv["Id", selected[0].Index].Value;

            string SQLRequest = "";

            SQLRequest += "DELETE [Guschin_provider]";
            SQLRequest += "WHERE Id = " + providerID;

            ExecuteRequest(SQLRequest);

            RefreshDGV(2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           PhoneHandbookFind(); //ФИО
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           PhoneHandbookFind(); //Тел. Номер
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           PhoneHandbookFind(); //Адрес
        }

        private void ExecuteRequest(string SQLRequest)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =  @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Управление данными\Database (1-ая форма (+поиск),+) 06.04.2023\Database\Database1.mdf;Integrated Security=True";

            conn.Open();//Открываем соединение

            //Создаем команду, ассоциированную с открытым соединением
            SqlCommand command = conn.CreateCommand();

            //Определяем саму команду и ее параметры
            command.CommandText = SQLRequest;

            //Выдаем команду, рез. команды помещаем в специальный объект
            SqlDataReader результат = command.ExecuteReader();
            conn.Close();	//Закрываем соединение	

        }

        private void PhoneHandbookFind()
        {

            string SQLRequest = "";
            SQLRequest += "SELECT * FROM [Guschin_abonent]\n";
            SQLRequest += "JOIN [Guschin_abonent_has_contact] ON [Guschin_abonent].Id = [Guschin_abonent_has_contact].abonent_id\n";
            SQLRequest += "JOIN [Guschin_contact] ON [Guschin_abonent_has_contact].contact_id = [Guschin_contact].Id\n";
            SQLRequest += "JOIN [Guschin_provider] ON [Guschin_contact].provider_id = [Guschin_provider].Id\n";

            SQLRequest += "WHERE [Guschin_abonent].address LIKE '%" + textBoxAddress.Text + "%' \n";
            SQLRequest += "  AND [Guschin_abonent].surname +' '+ [Guschin_abonent].name +' '+ [Guschin_abonent].patronymic LIKE '%" + textBoxSNP.Text + "%' \n";
            SQLRequest += "  AND [Guschin_contact].phone LIKE '%" + textBoxPhone.Text + "%' \n";

            //Создаем объект адаптера
            SqlDataAdapter adapter = new SqlDataAdapter(SQLRequest, connection);

            //Создаем объект-таблицу
            DataTable dataTable = new DataTable();

            //Заполняем таблицу посредством адаптера
            adapter.Fill(dataTable);

            DataGridView dgv = dataGridView4;

            dgv.DataSource = dataTable;

            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Id1"].Visible = false;
            dgv.Columns["Id2"].Visible = false;
            dgv.Columns["contact_id"].Visible = false;
            dgv.Columns["abonent_id"].Visible = false;
            dgv.Columns["provider_id"].Visible = false;
            dgv.Columns["score"].Visible = false;
            dgv.Columns["surname"].HeaderText = "Фамилия";
            dgv.Columns["name"].HeaderText = "Имя";
            dgv.Columns["patronymic"].HeaderText = "Отчество";
            dgv.Columns["address"].HeaderText = "Адрес";
            dgv.Columns["birth_date"].HeaderText = "Дата рождения";
            dgv.Columns["comment"].HeaderText = "Комментарий";
            dgv.Columns["phone"].HeaderText = "Номер телефона";
            dgv.Columns["type"].HeaderText = "Тип";
            dgv.Columns["name1"].HeaderText = "Название провайдера";


            dgv.Show();
        }
       

        private void buttonAdd4_Click(object sender, EventArgs e)
        {
            PhoneBookForm f = new PhoneBookForm();


            string SQLRequest1 = "SELECT * FROM [Guschin_abonent]";

            SqlDataAdapter adapter = new SqlDataAdapter(SQLRequest1, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            var dict1 = new System.Collections.Generic.Dictionary<int, string>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                dict1.Add((int)dataRow["Id"], dataRow["surname"].ToString() + " " + dataRow["name"].ToString() + " " + dataRow["patronymic"].ToString());
            }
            f.AbonentData = dict1;


            string SQLRequest2 = "SELECT * FROM [Guschin_contact]";

            SqlDataAdapter adapter2 = new SqlDataAdapter(SQLRequest2, connection);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);

            var dict2 = new System.Collections.Generic.Dictionary<int, string>();

            foreach (DataRow dataRow in dataTable2.Rows)
            {
                dict2.Add((int)dataRow["Id"], dataRow["phone"].ToString());
            }
            f.ContactData = dict2;



            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string SQLRequest3 = "";

                SQLRequest3 += "INSERT INTO [Guschin_abonent_has_contact] (abonent_id,contact_id)";
                SQLRequest3 += "VALUES ('" + f.AbonentID + "'," + f.ContactID + ")";

                ExecuteRequest(SQLRequest3);
            }

            RefreshDGV(3);
        }

        private void buttonChange4_Click(object sender, EventArgs e)
        {
            PhoneBookForm f = new PhoneBookForm();


            string SQLRequest1 = "SELECT * FROM [Guschin_abonent]";

            SqlDataAdapter adapter = new SqlDataAdapter(SQLRequest1, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            var dict1 = new System.Collections.Generic.Dictionary<int, string>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                dict1.Add((int)dataRow["Id"], dataRow["surname"].ToString() + " " + dataRow["name"].ToString() + " " + dataRow["patronymic"].ToString());
            }
            f.AbonentData = dict1;


            string SQLRequest2 = "SELECT * FROM [Guschin_contact]";

            SqlDataAdapter adapter2 = new SqlDataAdapter(SQLRequest2, connection);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);

            var dict2 = new System.Collections.Generic.Dictionary<int, string>();

            foreach (DataRow dataRow in dataTable2.Rows)
            {
                dict2.Add((int)dataRow["Id"], dataRow["phone"].ToString());
            }
            f.ContactData = dict2;



            var dgv = dataGridView4;
            var selected = dgv.SelectedRows;

            if (selected.Count == 0) { MessageBox.Show("Не выбрана строка."); return; }
            else if (selected.Count > 1) { MessageBox.Show("Выбрано больше одной строки."); return; };
            int contactID = (int)dgv["contact_id", selected[0].Index].Value;
            int abonentID = (int)dgv["abonent_id", selected[0].Index].Value;

            f.AbonentID = abonentID;
            f.ContactID = contactID;




            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                string SQLRequest3 = "";

                SQLRequest3 += "UPDATE [Guschin_abonent_has_contact] ";
                SQLRequest3 += "SET abonent_id = " + f.AbonentID + " , contact_id = " + f.ContactID + " ";
                SQLRequest3 += "WHERE abonent_id = " + abonentID + " AND contact_id = " + contactID;

                ExecuteRequest(SQLRequest3);
            }

            RefreshDGV(3);
        }

        private void buttonDelete4_Click(object sender, EventArgs e)
        {
            var dgv = dataGridView4;
            var selected = dgv.SelectedRows;
            if (selected.Count == 0) { MessageBox.Show("Не выбрана строка."); return; }
            else if (selected.Count > 1) { MessageBox.Show("Выбрано больше одной строки."); return; };
            int contactID = (int)dgv["contact_id", selected[0].Index].Value;
            int abonentID = (int)dgv["abonent_id", selected[0].Index].Value;

            string SQLRequest = "";

            SQLRequest += "DELETE [Guschin_abonent_has_contact] ";
            SQLRequest += "WHERE abonent_id = " + abonentID + " AND contact_id = " + contactID;

            ExecuteRequest(SQLRequest);

            RefreshDGV(3);
        }
    }

}
