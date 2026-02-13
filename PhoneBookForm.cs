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
    public partial class PhoneBookForm : Form
    {
        public PhoneBookForm()
        {
            InitializeComponent();
        }


        public Dictionary<int, string> AbonentData
        {
            set
            {
                comboBox1.DataSource = value.ToArray();
                comboBox1.DisplayMember = "Value";
            }
        }

        public Dictionary<int, string> ContactData
        {
            set
            {
                comboBox2.DataSource = value.ToArray();
                comboBox2.DisplayMember = "Value";
            }
        }

        public int AbonentID
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

        public int ContactID
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBox2.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in comboBox2.Items)
                {
                    if (item.Key == value)
                    { break; }
                    idx++;
                }
                comboBox2.SelectedIndex = idx;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") { MessageBox.Show("Абонент не задан."); return; }
            if (comboBox2.Text == "") { MessageBox.Show("Контакт не задан."); return; }


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
