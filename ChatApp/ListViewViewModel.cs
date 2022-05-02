using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChatApp
{
    public class ListViewViewModel
    {
        public ObservableCollection<ContactModel> ContactsList { get; set; }

        private Contact _selectedContact { get; set; }
        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                if(_selectedContact != value)
                {
                    _selectedContact = value;
                    HandleSelectedItem();
                }
            }
        }

        private void HandleSelectedItem()
        {
            Console.WriteLine("It workds");
        }

        public ListViewViewModel()
        {
            ContactsList = new ObservableCollection<ContactModel>
            {
                new ContactModel() {id=1, username = "Xamarin Forms", email = "xamarinforms@gmail.com"},
                new ContactModel() {id=2, username = "John Doe", email = "johndoe@gmail.com"},
                new ContactModel() {id=3, username = "Jane Doe", email = "janedoe@gmail.com"},
                new ContactModel() {id=4, username = "Zen Shift", email = "zenshift357@gmail.com"},
            };
        }

        public class Contact
        {
            public int id { get; set; }
            public string username { get; set; }
            public string email { get; set; }
        }
    }
}
