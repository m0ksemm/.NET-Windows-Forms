using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    internal class NotebookPresenter
    {
        private readonly IModel _model;
        private readonly INoteBookView1 _view;
        public NotebookPresenter(IModel model, INoteBookView1 view)
        {
            _model = model;
            _view = view;
            _view.AddEvent += new EventHandler<EventArgs>(Add);
            _view.RemoveEvent += new EventHandler<EventArgs>(Remove);
            _view.EditEvent += new EventHandler<EventArgs>(Edit);   
            _view.SaveEvent+= new EventHandler<EventArgs>(Save);
            _view.LoadEvent+= new EventHandler<EventArgs>(Load);
            UpdateView();
        }
        private void Add(object sender, EventArgs e) 
        {
            Person new_person = new Person(_view.TmpFirstName, _view.TmpLastName, _view.TmpAdress, _view.TmpPhone);
            _model.Contacts_List.Add(new_person);
            UpdateView();
        }
        private void Remove(object sender, EventArgs e)
        {
            _model.Contacts_List.RemoveAt(_view.Current);
            UpdateView();
        }
        private void Edit(object sender, EventArgs e)
        {
            _model.Contacts_List[_view.Current].FirstName = _view.TmpFirstName;
            _model.Contacts_List[_view.Current].LastName = _view.TmpLastName;
            _model.Contacts_List[_view.Current].Address = _view.TmpAdress;
            _model.Contacts_List[_view.Current].PhoneNumber = _view.TmpPhone;

            UpdateView();
        }
        private void Save(object sender, EventArgs e)
        {
            _model.Save(_view.File_name);
            UpdateView();
        }
        private void Load(object sender, EventArgs e)
        {
            _model.Load(_view.File_name);
            UpdateView();
        }
        private void UpdateView()
        {
            _view.Clear();
            foreach (Person person in _model.Contacts_List) 
            {
                _view.AddNewItem(person.FirstName, person.LastName, person.Address, person.PhoneNumber);
            }
        }
    }
}
