using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

//using ContactModel.Annotations;

namespace ChatApp
{
    public class ContactModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contact> ContactsList { get; set; }

        //Contact Viewer = new Contact();

        public ContactModel()
        {
            ContactsList = new ObservableCollection<Contact>
             {
                 /*new Contact() {Id=1, Username = "Xamarin Forms", Email = "xamarinforms@gmail.com"},
                 new Contact() {Id=2, Username = "John Doe", Email = "johndoe@gmail.com"},
                 new Contact() {Id=3, Username = "Jane Doe", Email = "janedoe@gmail.com"},
                 new Contact() {Id=4, Username = "Zen Shift", Email = "zenshift357@gmail.com"}*/
             };
        }

        public int _id { get; set; }
        public string _username { get; set; }
        public string _email { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public int id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        public string username { get { return _username; } set { _username = value; OnPropertyChanged(); } }
        public string email { get { return _email; } set { _email = value; OnPropertyChanged(); } }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class Contact
        {
            public int Id { get; set; }
            public string Username{ get; set; }
            public string Email { get; set; }

            /*public int id { get { return _id; } set { _id = value; } }
            public string username { get { return _username; } set { _username = value; } }
            public string email { get { return _email; } set { _email = value; } }*/
        }

        private Contact _selectedContact { get; set; }
        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                if (_selectedContact != value)
                {
                    _selectedContact = value;
                    //HandleSelectedItem();
                }
            }
        }

        /*private async void HandleSelectedItem()
        {
         
            //await Navigation.PushModalAsync(new ConversationPage("hello", "world"), true);

        }*/
    }
}
