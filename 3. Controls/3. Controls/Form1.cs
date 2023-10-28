using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);
            Set();
        }

        private int[] array = new int[16];
        private int time = 60;
        private List<Button> buttons = new List<Button>();

        private void Set() 
        {
            foreach (Button b in buttons) 
                b.Enabled = true;
            
                

            listBox1.Items.Clear();

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++) 
            {
                int element = rnd.Next(0, 100);
                for (int j = 0; j < i; j++) 
                {
                    if (array[j] == element) 
                    {
                        element = rnd.Next(0, 100);
                        j = 0;
                    }
                }
                array[i] = element;
            }  
            

            for (int i = 0; i < 16; i++) 
                buttons[i].Text = array[i].ToString();

            time_setter.Value = time;
            progressBar1.Value = 0;
            progressBar1.Maximum = time;
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int min = array.Min();

            int n = Array.IndexOf(array, min);

            if (sender == buttons[n] && Convert.ToInt32(buttons[n].Text) == min) 
            {
                listBox1.Items.Add(array[n].ToString());
                buttons[n].Enabled = false;
                array[n] = 101;
            }  
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            time = (int)time_setter.Value;
            timer1.Stop();
            Set();
        }
        private bool Win() 
        {
            if (listBox1.Items.Count == 16)
                return true;
            else return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Win()) 
            {
                timer1.Stop();
                time = (int)time_setter.Value;
                DialogResult result = MessageBox.Show("Do you want to play again?", "Good job! You won!",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Set();
                else this.Close();
            }
                time--;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                time = (int)time_setter.Value;
                DialogResult result = MessageBox.Show("Do you want to play again?", "You are out of time!",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Set();
                else this.Close();
            }
            else 
            {
                Text = time.ToString();
                progressBar1.Value += 1;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            time = (int)time_setter.Value;
            Set();
        }
    }
}