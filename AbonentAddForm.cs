using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class AbonentAddForm : Form
    {
        public AbonentAddForm()
        {
            InitializeComponent();
        }

        public string surname
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        public string name
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }
        public string patronymic
        {
            set { textBox3.Text = value; }
            get { return textBox3.Text; }
        }
        public string address
        {
            set { textBox4.Text = value; }
            get { return textBox4.Text; }
        }
        public DateTime birth_date
        {
            set { dateTimePicker1.Value = value; }
            get { return dateTimePicker1.Value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Фамилия не задана."); return; }
            if (textBox2.Text == "") { MessageBox.Show("Имя не задано."); return; }
            if (textBox3.Text == "") { MessageBox.Show("Отчество не задано."); return; }

            surname = textBox1.Text;
            name = textBox2.Text;
            patronymic = textBox3.Text;
            address = textBox4.Text;
            birth_date = dateTimePicker1.Value;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
