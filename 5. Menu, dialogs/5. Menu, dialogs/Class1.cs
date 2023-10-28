using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Menu__dialogs
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }
    }

    
}
