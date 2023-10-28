using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _5._Menu__dialogs
{
    public partial class Form1 : Form
    {
        public Authors A;
        public Form1()
        {
            InitializeComponent();

            A = new Authors();
        }

        private void Option_Item_Click(object sender, EventArgs e)
        {
            if (sender == AddAuthorToolStripMenuItem)
            {
                Form2 frm = new Form2();
                frm.MainForm = this;

                frm.Text = "Add new author:";

                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    comboBox1.Items.Add(frm.Info);
                    Author author = new Author(frm.Info);
                    A.AddAuthor(author);
                }
            }
            if (sender == deleteAuthorToolStripMenuItem)
            {
                if (comboBox1.Text != "")
                {
                    const string message = "Are you sure that you want to delete this author?\n" +
                                           "All his books will be deleted too";
                    const string caption = "Delete an author";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        A.RemoveAuthor(comboBox1.Text);
                        string s = comboBox1.Text;
                        comboBox1.Items.Remove(s);
                    }
                }
            }
            if (sender == editAuthorToolStripMenuItem)
            {
                if (comboBox1.Text != "")
                {
                    Form2 frm = new Form2();
                    string old = comboBox1.Text;

                    frm.MainForm = this;
                    frm.Info = comboBox1.Text;
                    frm.Text = "Edit an author:";

                    DialogResult res = frm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        int i = comboBox1.Items.IndexOf(old);
                        comboBox1.Items[i] = frm.Info;
                        A.EditAuthor(old, frm.Info);
                    }
                }
            }
            if (sender == addBookToolStripMenuItem)
            {
                if (comboBox1.Text != "")
                {
                    Form2 frm = new Form2();

                    string author = comboBox1.Text;

                    frm.MainForm = this;
                    frm.Info = "";
                    frm.Text = "Add new book:";

                    DialogResult res = frm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        
                        string bn = frm.Info;
                        Book book = new Book(bn);
                        
                        foreach (Author a in A.authors) 
                        {
                            if (a.Name == author) 
                            {
                                a.Books.Add(book);
                            }
                        }

                        listBox1.Items.Add(bn);
                    }
                }
            }
            if (sender == editBookToolStripMenuItem)
            {
                if (comboBox1.Text != "" && listBox1.SelectedItem != null)
                {
                    Form2 frm = new Form2();

                    string author = comboBox1.Text;
                    string old_book = listBox1.SelectedItem.ToString();

                    frm.MainForm = this;
                    frm.Info = old_book;
                    frm.Text = "Edit the book:";

                    DialogResult res = frm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        int i = listBox1.Items.IndexOf(old_book);
                        listBox1.Items[i] = frm.Info;
                        A.EditBook(author, old_book, frm.Info);
                    }
                }
            }
            if (sender == deleteBookToolStripMenuItem)
            {
                if (comboBox1.Text != "" && listBox1.SelectedItem != null)
                {
                    string author = comboBox1.Text;
                    string book = listBox1.SelectedItem.ToString();
                    A.RemoveBook(/*author,*/ book);

                    listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                }
            }
            Out();
        }

        public void Out() 
        {
            listBox1.Items.Clear();
            if (checkBox1.Checked == true && comboBox1.Text != "")
            {
                foreach (Author a in A.authors)
                {
                    if (a.Name == comboBox1.Text)
                    {
                        foreach (Book b in a.Books)
                        {
                            listBox1.Items.Add(b.Name);
                        }
                    }
                }
            }
            else
            {
                foreach (Author a in A.authors)
                {
                    foreach (Book b in a.Books)
                    {
                        listBox1.Items.Add(b.Name);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Out();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Out();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.DefaultExt = "txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                Serialize(saveFileDialog1.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    DeSerialize(openFileDialog1.FileName);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("You are trying to open incorrect file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Serialize(string file_name)
        {
            FileStream stream = new FileStream(file_name, FileMode.Create); ;
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, A.authors);
            stream.Close();
        }
        public void DeSerialize(string file_name)
        {
            Authors _A = new Authors();
            FileStream stream = new FileStream(file_name, FileMode.Open); ;
            BinaryFormatter formatter = new BinaryFormatter();
            _A.authors = (ArrayList)formatter.Deserialize(stream);
            stream.Close();

            foreach (Author a in _A.authors) 
            {
                A.authors.Add(a);
            }

            foreach (Author a in _A.authors)
            {
                comboBox1.Items.Add(a.Name);
                foreach (Book b in a.Books)
                {
                    listBox1.Items.Add(b.Name);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}