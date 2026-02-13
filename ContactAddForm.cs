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
    public partial class ContactAddForm : Form
    {
        public ContactAddForm()
        {
            InitializeComponent();


        }

        public string PhoneNumber
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        public string PhoneType
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }
        public string Provider;


        public Dictionary<int, string> ProviderData
        {
            set
            {
                comboBox1.DataSource = value.ToArray();
                comboBox1.DisplayMember = "Value";
            }
        }

        public int ProviderID
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in comboBox1.Items)
                {
                    if (item.Key == value)
                    { break; }
                    idx++;
                }
                comboBox1.SelectedIndex = idx;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Номер телефона не задан."); return; }
            if (textBox2.Text == "") { MessageBox.Show("Тип телефона не задан."); return; }
            if (comboBox1.Text == "") { MessageBox.Show("Провайдер не задан."); return; }

            PhoneNumber = textBox1.Text;
            PhoneType = textBox2.Text;
            Provider = ProviderID.ToString();



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
