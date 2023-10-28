namespace task2
{
    public partial class Form1 : Form
    {
        public int Lcount = 0;
        public int Rcount = 0;
        public int Mcount = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Press left, right of middle button of the mouse";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            if (e.Button == MouseButtons.Left) 
                Lcount++;
            else if (e.Button == MouseButtons.Right)
                Rcount++;
            else if (e.Button == MouseButtons.Middle)
                Mcount++;
            frm.Text = "Left button: " + Lcount.ToString() + " clicks;                Middle button: "
                + Mcount.ToString() + " clicks;                Right button: " + Rcount.ToString() + " clicks;";
        }
    }
}