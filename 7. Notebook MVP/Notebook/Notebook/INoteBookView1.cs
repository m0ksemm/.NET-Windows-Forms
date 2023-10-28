using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    internal interface INoteBookView1
    {
        public int Current { get; set; } //будет использоваться для передачи из вьюшки в презентер индекса выбранного элемента списка
        public string File_name { get; set; } //будет использоваться для передачи из вьюшки в презентер пути файла для сохранения/открытия 

        public event EventHandler<EventArgs> AddEvent; //событие добавления контакта
        public event EventHandler<EventArgs> RemoveEvent; //событие удаления
        public event EventHandler<EventArgs> EditEvent; //событие изменения существующего
        public event EventHandler<EventArgs> SaveEvent; //событие сохранения списка
        public event EventHandler<EventArgs> LoadEvent; //событие восстановления/открытия уже созданного ранее списка
        public void Clear(); //метод очистки списка
        public void AddNewItem(string f, string l, string a, string p); //метод добавления нового контакта в список
        public string TmpFirstName { get; set; } //временная переменная имени, для передачи имени текущего контакта в презентер
        public string TmpLastName { get; set; } //....для передачи фамилии текущего контакта
        public string TmpAdress { get; set; } //....для передачи адреса текущего контакта
        public string TmpPhone { get; set; } //....для передачи номера телефона текущего контакта
    }
}
