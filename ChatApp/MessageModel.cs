using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChatApp
{
    public class MessageModel : INotifyPropertyChanged
    {
        //todo
        int _id { get; set; }
        //string _userId { get; set; }
        string _message { get; set; }
        //int _receiverId { get; set; }
        string _usernameReceiver;
        string _usernameSender;

        public int id { get { return _id; } set { _id = value; OnPropertyChanged(nameof(id)); } }
        //public string userId { get { return _userId; } set { _userId = value; OnPropertyChanged(nameof(userId)); } }
        public string message { get { return _message; } set { _message = value; OnPropertyChanged(nameof(message)); } }
        public string usernameReceiver { get { return _usernameReceiver; } set { _usernameReceiver = value; OnPropertyChanged(nameof(usernameReceiver)); } }
        public string usernameSender { get { return _usernameSender; } set { _usernameSender= value; OnPropertyChanged(nameof(usernameSender)); } }
        //public string usernameSender
        //public int receiverId { get { return _receiverId; } set { _receiverId= value; OnPropertyChanged(nameof(receiverId)); } }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
