using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string F, string L, string A, string PN) 
        {
            FirstName = F;
            LastName = L;
            Address = A;
            PhoneNumber = PN;  
        }
        public string GetString()
        {
            return FirstName + " " + LastName + "; " + Address + "; " + PhoneNumber;
        }
    }
}
