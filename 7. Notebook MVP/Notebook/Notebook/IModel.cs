using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    internal interface IModel
    {
        public List<Person> Contacts_List {get; set;}
        public void Save(string file_name);
        public void Load(string file_name);
    }
}
