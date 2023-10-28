using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Menu__dialogs
{
    [Serializable]
    public class Author
    {
        public string Name { get; set; }
        public ArrayList Books = new ArrayList();
        public Author(string name) 
        {
            Name = name;
        }
    }
}
