namespace _1._Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 200;
            this.Height = 200;

            MessageBox.Show("»гра \"”гадай число\" ", "»гра \"”гадай число\"");
            MessageBox.Show("«агадайте любое число от 1 до 100", "»гра \"”гадай число\"");

            int N, left_limit = 0, right_limit = 101;

            while (true) 
            {
                N = (left_limit + right_limit) / 2;
                DialogResult result = MessageBox.Show("„исло больше или равно " + N.ToString() + "?", "»гра \"”гадай число\"",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    left_limit = N;
                }
                else if (result == DialogResult.No) 
                {
                    right_limit = N;
                }
                if (left_limit + 1 == right_limit)
                {
                    MessageBox.Show("¬аше число равно " + left_limit.ToString() + "!",
                        "»гра \"”гадай число\"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         result = MessageBox.Show("»грать снова?", "»гра \"”гадай число\"",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) 
                    {
                        left_limit = 0; right_limit = 101;
                        continue;
                    }
                    else if (result == DialogResult.No)
                        break;
                }
            }

            

           
        }
    }
}