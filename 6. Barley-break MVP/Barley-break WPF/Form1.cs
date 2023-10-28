using System;
using System.Windows.Forms;

namespace Barley_break_WPF
{
    public partial class Form1 : Form, IBarleyBreakView
    {
        public List<Button> buttons = new List<Button>();
        public event EventHandler<EventArgs> MooveEvent;
        public event EventHandler<EventArgs> RestartEvent;
        public int X { get; set; }
        public int Y { get; set; }

        private int time = 0;
        public int Progress 
        {
            get 
            { 
                return progressBar1.Value;
            }
            set 
            {
                progressBar1.Value = value;
            }
        }
        int[,] field = new int[4, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };

        public Form1()
        {
            InitializeComponent();
            buttons.Add(button1); buttons.Add(button2); 
            buttons.Add(button3); buttons.Add(button4); 
            buttons.Add(button5); buttons.Add(button6); 
            buttons.Add(button7); buttons.Add(button8); 
            buttons.Add(button9); buttons.Add(button10); 
            buttons.Add(button11); buttons.Add(button12); 
            buttons.Add(button13); buttons.Add(button14); 
            buttons.Add(button15); buttons.Add(button16);

            timer1.Start();
        }

        public int[,] Field
        {
            get
            {
                int[,] newField = new int[field.GetLength(0), field.GetLength(1)];
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        newField[i, j] = field[i, j];
                    }
                }
                return newField;
            }
            set
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        field[i, j] = value[i, j];
                    }
                }
                int k = 0;

                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        buttons[k].Text = value[i, j].ToString();
                        
                        if (value[i, j] == 16)
                            buttons[k].Visible = false;
                        else buttons[k].Visible = true;
                        k++;
                    }
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                int Choice = 0;
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i] != sender)
                    {
                        Choice++;
                    }
                    else break;
                }
                X = Choice / 4;
                Y = Choice % 4;
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                MooveEvent?.Invoke(this, EventArgs.Empty);


                if (Progress == 15) 
                {
                    timer1.Stop();
                    DialogResult d= MessageBox.Show(
                    "It took you " + time.ToString() + " seconds. Do you want to play again?",
                    "You have won!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    time = 0;
                    if (d == DialogResult.Yes)
                    {
                        Progress = 0;

                        RestartEvent?.Invoke(this, EventArgs.Empty);
                        timer1.Start();
                    }
                    else 
                    {
                        this.Close();
                    }
                    

                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                        "ERROR 2 !!!",
                        "Message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                MessageBox.Show(ex.Message);

                
            }
        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                RestartEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                        "ERROR 3 !!!",
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}