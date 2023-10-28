using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    [Serializable]
    internal class Model : IModel
    {
        public List<Person> contacts_list = new List<Person>(); 
        public Model() 
        {
        }  
        public List<Person> Contacts_List 
        {
            get 
            {
                List <Person> new_list = new List <Person>();
                foreach (Person person in contacts_list) 
                {
                    new_list.Add(person);
                }
                return contacts_list; 
            }
            set 
            {
                List<Person> new_list = new List<Person>();
                foreach (Person person in value) 
                {
                    new_list.Add (person);
                }
                contacts_list = new_list; 
            }
        }
        public void Save(string file_name) 
        {
            FileStream stream = new FileStream(file_name, FileMode.Create); ;
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, contacts_list);
            stream.Close();
        }
        public void Load(string file_name) 
        {
            FileStream stream = new FileStream(file_name, FileMode.Open); ;
            BinaryFormatter formatter = new BinaryFormatter();
            List<Person> list = (List<Person>)formatter.Deserialize(stream);
            stream.Close();
            Contacts_List = list;
        }
    }
}
