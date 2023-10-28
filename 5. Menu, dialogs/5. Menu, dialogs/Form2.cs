using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._Menu__dialogs
{
    public partial class Form2 : Form
    {
        public Form MainForm { get; set; }
        public string Info 
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = Info;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
