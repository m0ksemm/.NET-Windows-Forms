using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _4._Barley_break
{
    public partial class Form1 : Form
    {
        private List<Button> buttons = new List<Button>();
        private int time = 0;

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

            for (int i = 0; i < buttons.Count; i++) 
                buttons[i].Text = (i + 1).ToString();
            buttons[15].Text = "0";

            Mix();
            toolStripStatusLabel2.Text = "  " + time.ToString();
        }

        private void Mix() 
        {
            time = 0;
            timer1.Start();
            toolStripProgressBar1.Value = 0;

            toolStripStatusLabel2.Text = "  " + time.ToString();
            for (int j = 0; j < 100; j++)
            {
                Random rnd = new Random();
                int n = -1;
                for (int i = 0; i < 16; i++)
                {
                    if (buttons[i].Text == "0")
                    {
                        n = i; break;
                    }
                }
                if (n == 0)////////////////////////////BUTTON 1111111111111111111111111
                {
                    int x = rnd.Next(1, 3);
                    if (x == 1)
                    {
                        button1.Text = button2.Text;
                        button1.Visible = true;
                        button2.Text = 0.ToString();
                        button2.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button1.Text = button5.Text;
                        button1.Visible = true;
                        button5.Text = 0.ToString();
                        button5.Visible = false;
                    }
                }
                else if (n == 1)////////////////////////BUTTON 2222222222222222222222222
                {
                    int x = rnd.Next(1, 4);
                    if (x == 1)
                    {
                        button2.Text = button1.Text;
                        button2.Visible = true;
                        button1.Text = 0.ToString();
                        button1.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button2.Text = button6.Text;
                        button2.Visible = true;
                        button6.Text = 0.ToString();
                        button6.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button2.Text = button3.Text;
                        button2.Visible = true;
                        button3.Text = 0.ToString();
                        button3.Visible = false;
                    }
                }
                else if (n == 2)////////////////////////BUTTON 333333333333333333333333
                {
                    int x = rnd.Next(1, 4);
                    if (x == 1)
                    {
                        button3.Text = button2.Text;
                        button3.Visible = true;
                        button2.Text = 0.ToString();
                        button2.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button3.Text = button4.Text;
                        button3.Visible = true;
                        button4.Text = 0.ToString();
                        button4.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button3.Text = button7.Text;
                        button3.Visible = true;
                        button7.Text = 0.ToString();
                        button7.Visible = false;
                    }

                }
                else if (n == 3) ///////////////////////BUTTON 44444444444444444444444
                {
                    int x = rnd.Next(1, 3);
                    if (x == 1)
                    {
                        button4.Text = button3.Text;
                        button4.Visible = true;
                        button3.Text = 0.ToString();
                        button3.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button4.Text = button8.Text;
                        button4.Visible = true;
                        button8.Text = 0.ToString();
                        button8.Visible = false;
                    }
                }
                else if (n == 4) ///////////////////////BUTTON 555555555555555555555555
                {
                    int x = rnd.Next(1, 4);
                    if (x == 1)
                    {
                        button5.Text = button1.Text;
                        button5.Visible = true;
                        button1.Text = 0.ToString();
                        button1.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button5.Text = button6.Text;
                        button5.Visible = true;
                        button6.Text = 0.ToString();
                        button6.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button5.Text = button9.Text;
                        button5.Visible = true;
                        button9.Text = 0.ToString();
                        button9.Visible = false;
                    }
                }
                else if (n == 5) ///////////////////////BUTTON 666666666666666666666666
                {
                    int x = rnd.Next(1, 5);
                    if (x == 1)
                    {
                        button6.Text = button5.Text;
                        button6.Visible = true;
                        button5.Text = 0.ToString();
                        button5.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button6.Text = button2.Text;
                        button6.Visible = true;
                        button2.Text = 0.ToString();
                        button2.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button6.Text = button7.Text;
                        button6.Visible = true;
                        button7.Text = 0.ToString();
                        button7.Visible = false;
                    }
                    else if (x == 4)
                    {
                        button6.Text = button10.Text;
                        button6.Visible = true;
                        button10.Text = 0.ToString();
                        button10.Visible = false;
                    }
                }
                else if (n == 6) ///////////////////////BUTTON 77777777777777777777
                {
                    int x = rnd.Next(1, 5);
                    if (x == 1)
                    {
                        button7.Text = button6.Text;
                        button7.Visible = true;
                        button6.Text = 0.ToString();
                        button6.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button7.Text = button3.Text;
                        button7.Visible = true;
                        button3.Text = 0.ToString();
                        button3.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button7.Text = button8.Text;
                        button7.Visible = true;
                        button8.Text = 0.ToString();
                        button8.Visible = false;
                    }
                    else if (x == 4)
                    {
                        button7.Text = button11.Text;
                        button7.Visible = true;
                        button11.Text = 0.ToString();
                        button11.Visible = false;
                    }
                }
                else if (n == 7) ///////////////////////BUTTON 8888888888888888888
                {
                    int x = rnd.Next(1, 4);
                    if (x == 1)
                    {
                        button8.Text = button4.Text;
                        button8.Visible = true;
                        button4.Text = 0.ToString();
                        button4.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button8.Text = button7.Text;
                        button8.Visible = true;
                        button7.Text = 0.ToString();
                        button7.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button8.Text = button12.Text;
                        button8.Visible = true;
                        button12.Text = 0.ToString();
                        button12.Visible = false;
                    }
                }
                else if (n == 8) ///////////////////////BUTTON 9999999999999999999
                {
                    int x = rnd.Next(1, 4);
                    if (x == 1)
                    {
                        button9.Text = button5.Text;
                        button9.Visible = true;
                        button5.Text = 0.ToString();
                        button5.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button9.Text = button10.Text;
                        button9.Visible = true;
                        button10.Text = 0.ToString();
                        button10.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button9.Text = button13.Text;
                        button9.Visible = true;
                        button13.Text = 0.ToString();
                        button13.Visible = false;
                    }
                }
                else if (n == 9) ///////////////////////BUTTON 10.10.10.10.10.10.10.10.
                {
                    int x = rnd.Next(1, 5);
                    if (x == 1)
                    {
                        button10.Text = button9.Text;
                        button10.Visible = true;
                        button9.Text = 0.ToString();
                        button9.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button10.Text = button6.Text;
                        button10.Visible = true;
                        button6.Text = 0.ToString();
                        button6.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button10.Text = button11.Text;
                        button10.Visible = true;
                        button11.Text = 0.ToString();
                        button11.Visible = false;
                    }
                    else if (x == 4)
                    {
                        button10.Text = button14.Text;
                        button10.Visible = true;
                        button14.Text = 0.ToString();
                        button14.Visible = false;
                    }
                }
                else if (n == 10) ///////////////////////BUTTON 11.11.11.11.11.11.11.11
                {
                    int x = rnd.Next(1, 5);
                    if (x == 1)
                    {
                        button11.Text = button10.Text;
                        button11.Visible = true;
                        button10.Text = 0.ToString();
                        button10.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button11.Text = button7.Text;
                        button11.Visible = true;
                        button7.Text = 0.ToString();
                        button7.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button11.Text = button12.Text;
                        button11.Visible = true;
                        button12.Text = 0.ToString();
                        button12.Visible = false;
                    }
                    else if (x == 4)
                    {
                        button11.Text = button15.Text;
                        button11.Visible = true;
                        button15.Text = 0.ToString();
                        button15.Visible = false;
                    }
                }
                else if (n == 11) ///////////////////////BUTTON 12.12.12.12.12.12.12.12
                {
                    int x = rnd.Next(1, 4);
                    if (x == 1)
                    {
                        button12.Text = button8.Text;
                        button12.Visible = true;
                        button8.Text = 0.ToString();
                        button8.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button12.Text = button11.Text;
                        button12.Visible = true;
                        button11.Text = 0.ToString();
                        button11.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button12.Text = button16.Text;
                        button12.Visible = true;
                        button16.Text = 0.ToString();
                        button16.Visible = false;
                    }
                }
                else if (n == 12) ///////////////////////BUTTON 13.13.13.13.13.13.13.13
                {
                    int x = rnd.Next(1, 3);
                    if (x == 1)
                    {
                        button13.Text = button9.Text;
                        button13.Visible = true;
                        button9.Text = 0.ToString();
                        button9.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button13.Text = button14.Text;
                        button13.Visible = true;
                        button14.Text = 0.ToString();
                        button14.Visible = false;
                    }
                }
                else if (n == 13) ///////////////////////BUTTON 14.14.14.14.14.14.14.14
                {
                    int x = rnd.Next(1, 4);
                    if (x == 1)
                    {
                        button14.Text = button13.Text;
                        button14.Visible = true;
                        button13.Text = 0.ToString();
                        button13.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button14.Text = button10.Text;
                        button14.Visible = true;
                        button10.Text = 0.ToString();
                        button10.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button14.Text = button15.Text;
                        button14.Visible = true;
                        button15.Text = 0.ToString();
                        button15.Visible = false;
                    }
                }
                else if (n == 14) ///////////////////////BUTTON 15.15.15.15.15.15.15.15
                {
                    int x = rnd.Next(1, 4);
                    if (x == 1)
                    {
                        button15.Text = button14.Text;
                        button15.Visible = true;
                        button14.Text = 0.ToString();
                        button14.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button15.Text = button11.Text;
                        button15.Visible = true;
                        button11.Text = 0.ToString();
                        button11.Visible = false;
                    }
                    else if (x == 3)
                    {
                        button15.Text = button16.Text;
                        button15.Visible = true;
                        button16.Text = 0.ToString();
                        button16.Visible = false;
                    }
                }
                else if (n == 15) ///////////////////////BUTTON 16.16.16.16.16.16.16.16
                {
                    int x = rnd.Next(1, 3);
                    if (x == 1)
                    {
                        button16.Text = button15.Text;
                        button16.Visible = true;
                        button15.Text = 0.ToString();
                        button15.Visible = false;
                    }
                    else if (x == 2)
                    {
                        button16.Text = button12.Text;
                        button16.Visible = true;
                        button12.Text = 0.ToString();
                        button12.Visible = false;
                    }
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        


        private void button1_Click(object sender, EventArgs e)
        {
            int n = -1;
            for (int i = 0; i < 16; i++)
            {
                if (buttons[i].Text == "0")
                {
                    n = i; break;
                }
            }

            if (n == 0)////////////////////////////BUTTON 1111111111111111111111111
            {
                if (sender == button2)
                {
                    button1.Text = button2.Text;
                    button1.Visible = true;
                    button2.Text = 0.ToString();
                    button2.Visible = false;
                }
                else if (sender == button5)
                {
                    button1.Text = button5.Text;
                    button1.Visible = true;
                    button5.Text = 0.ToString();
                    button5.Visible = false;
                }
            }
            else if (n == 1)////////////////////////BUTTON 2222222222222222222222222
            {
                if (sender == button1)
                {
                    button2.Text = button1.Text;
                    button2.Visible = true;
                    button1.Text = 0.ToString();
                    button1.Visible = false;
                }
                else if (sender == button6)
                {
                    button2.Text = button6.Text;
                    button2.Visible = true;
                    button6.Text = 0.ToString();
                    button6.Visible = false;
                }
                else if (sender == button3)
                {
                    button2.Text = button3.Text;
                    button2.Visible = true;
                    button3.Text = 0.ToString();
                    button3.Visible = false;
                }
            }
            else if (n == 2)////////////////////////BUTTON 333333333333333333333333
            {
                if (sender == button2)
                {
                    button3.Text = button2.Text;
                    button3.Visible = true;
                    button2.Text = 0.ToString();
                    button2.Visible = false;
                }
                else if (sender == button4)
                {
                    button3.Text = button4.Text;
                    button3.Visible = true;
                    button4.Text = 0.ToString();
                    button4.Visible = false;
                }
                else if (sender == button7)
                {
                    button3.Text = button7.Text;
                    button3.Visible = true;
                    button7.Text = 0.ToString();
                    button7.Visible = false;
                }

            }
            else if (n == 3) ///////////////////////BUTTON 44444444444444444444444
            {
                if (sender == button3)
                {
                    button4.Text = button3.Text;
                    button4.Visible = true;
                    button3.Text = 0.ToString();
                    button3.Visible = false;
                }
                else if (sender == button8)
                {
                    button4.Text = button8.Text;
                    button4.Visible = true;
                    button8.Text = 0.ToString();
                    button8.Visible = false;
                }
            }
            else if (n == 4) ///////////////////////BUTTON 555555555555555555555555
            {
                if (sender == button1)
                {
                    button5.Text = button1.Text;
                    button5.Visible = true;
                    button1.Text = 0.ToString();
                    button1.Visible = false;
                }
                else if (sender == button6)
                {
                    button5.Text = button6.Text;
                    button5.Visible = true;
                    button6.Text = 0.ToString();
                    button6.Visible = false;
                }
                else if (sender == button9)
                {
                    button5.Text = button9.Text;
                    button5.Visible = true;
                    button9.Text = 0.ToString();
                    button9.Visible = false;
                }
            }
            else if (n == 5) ///////////////////////BUTTON 666666666666666666666666
            {
                if (sender == button5)
                {
                    button6.Text = button5.Text;
                    button6.Visible = true;
                    button5.Text = 0.ToString();
                    button5.Visible = false;
                }
                else if (sender == button2)
                {
                    button6.Text = button2.Text;
                    button6.Visible = true;
                    button2.Text = 0.ToString();
                    button2.Visible = false;
                }
                else if (sender == button7)
                {
                    button6.Text = button7.Text;
                    button6.Visible = true;
                    button7.Text = 0.ToString();
                    button7.Visible = false;
                }
                else if (sender == button10)
                {
                    button6.Text = button10.Text;
                    button6.Visible = true;
                    button10.Text = 0.ToString();
                    button10.Visible = false;
                }
            }
            else if (n == 6) ///////////////////////BUTTON 77777777777777777777
            {
                if (sender == button6)
                {
                    button7.Text = button6.Text;
                    button7.Visible = true;
                    button6.Text = 0.ToString();
                    button6.Visible = false;
                }
                else if (sender == button3)
                {
                    button7.Text = button3.Text;
                    button7.Visible = true;
                    button3.Text = 0.ToString();
                    button3.Visible = false;
                }
                else if (sender == button8)
                {
                    button7.Text = button8.Text;
                    button7.Visible = true;
                    button8.Text = 0.ToString();
                    button8.Visible = false;
                }
                else if (sender == button11)
                {
                    button7.Text = button11.Text;
                    button7.Visible = true;
                    button11.Text = 0.ToString();
                    button11.Visible = false;
                }
            }
            else if (n == 7) ///////////////////////BUTTON 8888888888888888888
            {
                if (sender == button4)
                {
                    button8.Text = button4.Text;
                    button8.Visible = true;
                    button4.Text = 0.ToString();
                    button4.Visible = false;
                }
                else if (sender == button7)
                {
                    button8.Text = button7.Text;
                    button8.Visible = true;
                    button7.Text = 0.ToString();
                    button7.Visible = false;
                }
                else if (sender == button12)
                {
                    button8.Text = button12.Text;
                    button8.Visible = true;
                    button12.Text = 0.ToString();
                    button12.Visible = false;
                }
            }
            else if (n == 8) ///////////////////////BUTTON 9999999999999999999
            {
                if (sender == button5)
                {
                    button9.Text = button5.Text;
                    button9.Visible = true;
                    button5.Text = 0.ToString();
                    button5.Visible = false;
                }
                else if (sender == button10)
                {
                    button9.Text = button10.Text;
                    button9.Visible = true;
                    button10.Text = 0.ToString();
                    button10.Visible = false;
                }
                else if (sender == button13)
                {
                    button9.Text = button13.Text;
                    button9.Visible = true;
                    button13.Text = 0.ToString();
                    button13.Visible = false;
                }
            }
            else if (n == 9) ///////////////////////BUTTON 10.10.10.10.10.10.10.10.
            {
                if (sender == button9)
                {
                    button10.Text = button9.Text;
                    button10.Visible = true;
                    button9.Text = 0.ToString();
                    button9.Visible = false;
                }
                else if (sender == button6)
                {
                    button10.Text = button6.Text;
                    button10.Visible = true;
                    button6.Text = 0.ToString();
                    button6.Visible = false;
                }
                else if (sender == button11)
                {
                    button10.Text = button11.Text;
                    button10.Visible = true;
                    button11.Text = 0.ToString();
                    button11.Visible = false;
                }
                else if (sender == button14)
                {
                    button10.Text = button14.Text;
                    button10.Visible = true;
                    button14.Text = 0.ToString();
                    button14.Visible = false;
                }
            }
            else if (n == 10) ///////////////////////BUTTON 11.11.11.11.11.11.11.11
            {
                if (sender == button10)
                {
                    button11.Text = button10.Text;
                    button11.Visible = true;
                    button10.Text = 0.ToString();
                    button10.Visible = false;
                }
                else if (sender == button7)
                {
                    button11.Text = button7.Text;
                    button11.Visible = true;
                    button7.Text = 0.ToString();
                    button7.Visible = false;
                }
                else if (sender == button12)
                {
                    button11.Text = button12.Text;
                    button11.Visible = true;
                    button12.Text = 0.ToString();
                    button12.Visible = false;
                }
                else if (sender == button15)
                {
                    button11.Text = button15.Text;
                    button11.Visible = true;
                    button15.Text = 0.ToString();
                    button15.Visible = false;
                }
            }
            else if (n == 11) ///////////////////////BUTTON 12.12.12.12.12.12.12.12
            {
                if (sender == button8)
                {
                    button12.Text = button8.Text;
                    button12.Visible = true;
                    button8.Text = 0.ToString();
                    button8.Visible = false;
                }
                else if (sender == button11)
                {
                    button12.Text = button11.Text;
                    button12.Visible = true;
                    button11.Text = 0.ToString();
                    button11.Visible = false;
                }
                else if (sender == button16)
                {
                    button12.Text = button16.Text;
                    button12.Visible = true;
                    button16.Text = 0.ToString();
                    button16.Visible = false;
                }
            }
            else if (n == 12) ///////////////////////BUTTON 13.13.13.13.13.13.13.13
            {
                if (sender == button9)
                {
                    button13.Text = button9.Text;
                    button13.Visible = true;
                    button9.Text = 0.ToString();
                    button9.Visible = false;
                }
                else if (sender == button14)
                {
                    button13.Text = button14.Text;
                    button13.Visible = true;
                    button14.Text = 0.ToString();
                    button14.Visible = false;
                }
            }
            else if (n == 13) ///////////////////////BUTTON 14.14.14.14.14.14.14.14
            {
                if (sender == button13)
                {
                    button14.Text = button13.Text;
                    button14.Visible = true;
                    button13.Text = 0.ToString();
                    button13.Visible = false;
                }
                else if (sender == button10)
                {
                    button14.Text = button10.Text;
                    button14.Visible = true;
                    button10.Text = 0.ToString();
                    button10.Visible = false;
                }
                else if (sender == button15)
                {
                    button14.Text = button15.Text;
                    button14.Visible = true;
                    button15.Text = 0.ToString();
                    button15.Visible = false;
                }
            }
            else if (n == 14) ///////////////////////BUTTON 15.15.15.15.15.15.15.15
            {
                if (sender == button14)
                {
                    button15.Text = button14.Text;
                    button15.Visible = true;
                    button14.Text = 0.ToString();
                    button14.Visible = false;
                }
                else if (sender == button11)
                {
                    button15.Text = button11.Text;
                    button15.Visible = true;
                    button11.Text = 0.ToString();
                    button11.Visible = false;
                }
                else if (sender == button16)
                {
                    button15.Text = button16.Text;
                    button15.Visible = true;
                    button16.Text = 0.ToString();
                    button16.Visible = false;
                }
            }
            else if (n == 15) ///////////////////////BUTTON 16.16.16.16.16.16.16.16
            {
                if (sender == button15) 
                {
                    button16.Text = button15.Text;
                    button16.Visible = true;
                    button15.Text = 0.ToString();
                    button15.Visible = false;
                }
                else if (sender == button12) 
                {
                    button16.Text = button12.Text;
                    button16.Visible = true;
                    button12.Text = 0.ToString();
                    button12.Visible = false;
                }
            }
            Progress();
            if (IfWon()) 
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Do you want to play again?",
                    "You have won!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                    Mix();       
                else Close();
            }
        }

        private void Progress() 
        {
            int j = 0;
            for (int i = 0; i < 16; i++)
            {
                if (i + 1 == Convert.ToInt32(buttons[i].Text)) 
                    j++;
            }
            toolStripProgressBar1.Value= j;
        }

        private bool IfWon() 
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" &&
                button4.Text == "4" && button5.Text == "5" && button6.Text == "6" &&
                button7.Text == "7" && button8.Text == "8" && button9.Text == "9" &&
                button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15") 
            {
                toolStripProgressBar1.Value = 15;
                return true;
            } 
            else return false;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            Mix();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            toolStripStatusLabel2.Text = "  " + time.ToString();
        }
    }
}