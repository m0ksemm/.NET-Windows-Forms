using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class Form2 : Form
    {
        public string Operand1 
        {
            get 
            {
                return textBox1.Text;
            }
            set 
            {
                textBox1.Text = value;
            } 
        }
        public string Operand2 
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }
        public string Operand3
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }
        public string Operand4
        {
            get
            {
                return textBox4.Text;
            }
            set
            {
                textBox4.Text = value;
            }
        }
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        public Form2(string o1, string o2, string o3, string o4)
        {
            InitializeComponent();
            Operand1 = o1;
            Operand2 = o2;
            Operand3 = o3;
            Operand4 = o4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void DataCheck(object sender, EventArgs e)
        {
            if (Operand1.Length >= 2) 
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }
    }
}
