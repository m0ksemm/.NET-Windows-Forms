namespace task3
{
    public partial class Form1 : Form
    {
        static int dirrection;
        static int left;
        static int top;
        public Form1()
        {
            InitializeComponent();
            Width = 300;
            Height = 300;
            this.Text = "ENTER";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Width = 300;
            Height = 300;
            dirrection = 1;
            if (e.KeyCode == Keys.Return)
            {
                this.Text = "ESCAPE";
                left = 0;
                top = 0;
                Location = new Point(left, top);
                timer1.Start();
            }
            if (e.KeyCode == Keys.Escape) 
            {
                timer1.Stop();
                this.Text = "ENTER";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dirrection == 1)
            {
                if (left + 300 < Screen.PrimaryScreen.Bounds.Width)
                {
                    left += 5;
                    Location = new Point(left, top);
                }
                else 
                    dirrection = 2;
                
            }
            else if (dirrection == 2)
            {
                if (top + 300 < Screen.PrimaryScreen.Bounds.Height)
                {
                    top += 5;
                    Location = new Point(left, top);
                }
                else dirrection = 3;
            }
            else if (dirrection == 3)
            {
                if (left > 0)
                {
                    left -= 5;
                    Location = new Point(left, top);
                }
                else dirrection = 4;
            }
            else if (dirrection == 4)
            {
                if (top > 0)
                {
                    top -= 5;
                    Location = new Point(left, top);
                }
                else dirrection = 1;
            }
        }
    }

}