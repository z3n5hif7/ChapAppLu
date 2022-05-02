using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChatApp
{
    public class UserModel : INotifyPropertyChanged
    {
        public int _id { get; set; }
        public string _username { get; set; }
        public string _email { get; set; }
        public string _password { get; set; }

        public int id {  get { return _id; } set { _id = value; OnPropertyChanged(nameof(id)); } }
        public string username { get { return _username; } set { _username = value; OnPropertyChanged(nameof(username)); } }
        public string email { get { return _email; } set { _email = value; OnPropertyChanged(nameof(email)); } }
        public string password { get { return _password; } set { _password = value; OnPropertyChanged(nameof(password)); } }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
