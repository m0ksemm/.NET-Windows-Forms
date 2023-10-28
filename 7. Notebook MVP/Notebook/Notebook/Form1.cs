using System;
using System.Net;
using System.Windows.Forms;

namespace Notebook
{
    public struct ListItem //структура, в которой будут храниться контакты во вьюшке 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string GetString() //получение контакта в виде строки для того, чтобы поместить её listBox1
        {
            return FirstName + " " + LastName + "; " + Adress + "; " + Phone;
        }
    }
    public partial class Form1 : Form, INoteBookView1
    {
        public int Current { get; set; }
        public string File_name { get; set; }
        public string TmpFirstName { get; set; }
        public string TmpLastName { get; set; }
        public string TmpAdress { get; set; }
        public string TmpPhone { get; set; }
        public List<ListItem> Contacts = new List<ListItem>();
        public void AddNewItem(string f, string l, string a, string p)
        {
            ListItem new_item = new ListItem();
            new_item.FirstName = f;
            new_item.LastName = l;
            new_item.Adress = a;
            new_item.Phone = p;

            Contacts.Add(new_item);
            
            listBox1.Items.Add(new_item.GetString());
        }
        public event EventHandler<EventArgs> AddEvent;
        public event EventHandler<EventArgs> RemoveEvent;
        public event EventHandler<EventArgs> EditEvent;
        public event EventHandler<EventArgs> SaveEvent;
        public event EventHandler<EventArgs> LoadEvent;
        public void Clear() 
        {
            Contacts.Clear();
            listBox1.Items.Clear();
        }
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                form2.Text = "Add new contact";
                form2.ShowDialog();
                if (form2.DialogResult == DialogResult.OK) 
                {
                    TmpFirstName = form2.Operand1;
                    TmpLastName = form2.Operand2;
                    TmpAdress = form2.Operand3;
                    TmpPhone = form2.Operand4;
                    AddEvent?.Invoke(this, EventArgs.Empty);
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 1", "Problem with adding a new list item",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Current = listBox1.Items.IndexOf(listBox1.SelectedItem);
                RemoveEvent?.Invoke(this, EventArgs.Empty);
                button2.Enabled = false;
                button3.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 2", "Problem with deleting of an item",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Current = listBox1.Items.IndexOf(listBox1.SelectedItem);
                TmpFirstName = Contacts[Current].FirstName;
                TmpLastName = Contacts[Current].LastName;
                TmpAdress = Contacts[Current].Adress;
                TmpPhone = Contacts[Current].Phone;
                Form2 form2 = new Form2(TmpFirstName, TmpLastName, TmpAdress, TmpPhone);
                form2.Text = "Edit this contact";
                form2.ShowDialog();
                if (form2.DialogResult == DialogResult.OK)
                {
                    TmpFirstName = form2.Operand1;
                    TmpLastName = form2.Operand2;
                    TmpAdress = form2.Operand3;
                    TmpPhone = form2.Operand4;
                    EditEvent?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( "ERROR 3", "Problem with editing of an item",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Text Files | *.txt";
                saveFileDialog1.DefaultExt = "txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    File_name = saveFileDialog1.FileName;
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 4", "Saving problem",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                MessageBox.Show(ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File_name = openFileDialog1.FileName;
                    LoadEvent?.Invoke(this, EventArgs.Empty);
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 5", "Loading problem",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                MessageBox.Show(ex.Message);
            }
        }
        private void Selected(object sender, EventArgs e) //если не выбран ни один элемент списка, то кнопки "Редактировать" и "Удалить" доступны не будут
        {
            if (listBox1.SelectedItem != null) 
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
    }
}