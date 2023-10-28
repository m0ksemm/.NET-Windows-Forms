using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5._Menu__dialogs
{
    [Serializable]
    public class Authors
    {
        public ArrayList authors = new ArrayList();
        public void AddAuthor(Author a) 
        {
            authors.Add(a);
        }
        public void RemoveAuthor(string name) 
        {
            int index = -1; ;
            int i = 0; 
            foreach (Author author in authors) 
            {
                if (author.Name == name) 
                {
                    index = i;
                    break;
                }
                i++;
            }
            if (index != -1)
                authors.RemoveAt(index);
        }
        public void EditAuthor(string old_name, string new_name) 
        {
            foreach (Author author in authors)
            {
                if (author.Name == old_name)
                {
                    author.Name = new_name;
                    break;
                }
            }
        }
        public void AddBook(string a, Book b)
        {
            foreach (Author author in authors)
            {
                if (author.Name == a)
                {
                    author.Books.Add(b);
                    break;
                }
            }
        }
        public void EditBook(string author, string old_book, string new_book) 
        {
            foreach (Author a in authors) 
            {
                if (a.Name == author) 
                {
                    foreach (Book b in a.Books) 
                    {
                        if (b.Name == old_book)
                        {
                            b.Name = new_book;
                            break;
                        }
                    }
                }
            }
        }
        public void RemoveBook(string book_name)
        {
            int index = 0;
            string auth = "";
            foreach (Author a in authors)
            {
                int i = 0;
                foreach (Book b in a.Books)
                {
                    if (b.Name == book_name)
                    {
                        auth = a.Name;
                        index = i;
                        break;
                    }                   
                    i++;
                }
            }
            foreach (Author a in authors) 
            {
                if (a.Name == auth) 
                {
                    a.Books.RemoveAt(index);
                    break;
                }
            }  
        }
    }    
}
