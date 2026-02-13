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
    public partial class ProviderAddForm : Form
    {
        public ProviderAddForm()
        {
            InitializeComponent();
        }

        public string name
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        public string rate
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Название провайдера не задано."); return; }
            //if (textBox2.Text == "") { MessageBox.Show("Тип телефона не задан."); return; }


            name = textBox1.Text;
            rate = textBox2.Text;

            rate = rate.Replace(',', '.');

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
