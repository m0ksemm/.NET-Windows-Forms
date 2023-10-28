namespace _1._Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 200;
            this.Height = 200;

            MessageBox.Show("���� \"������ �����\" ", "���� \"������ �����\"");
            MessageBox.Show("��������� ����� ����� �� 1 �� 100", "���� \"������ �����\"");

            int N, left_limit = 0, right_limit = 101;

            while (true) 
            {
                N = (left_limit + right_limit) / 2;
                DialogResult result = MessageBox.Show("����� ������ ��� ����� " + N.ToString() + "?", "���� \"������ �����\"",
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
                    MessageBox.Show("���� ����� ����� " + left_limit.ToString() + "!",
                        "���� \"������ �����\"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         result = MessageBox.Show("������ �����?", "���� \"������ �����\"",
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