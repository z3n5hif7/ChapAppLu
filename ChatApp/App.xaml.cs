using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using static ChatApp.ContactModel;
//using Xamarin.Essentials;

namespace ChatApp
{
    public partial class App : Application
    {

        public static ObservableCollection<UserModel> TestList { get; set; } = new ObservableCollection<UserModel>();
        public static ObservableCollection<ContactModel> ContactList { get; set; } = new ObservableCollection<ContactModel>();
        public static ObservableCollection<MessageModel> MessageList{ get; set; } = new ObservableCollection<MessageModel>();
        public static ContactModel LVVM = new ContactModel();

        public App()
        {
            //TestList = null;
            TestList.Add(new UserModel() { id = 1, email = "z3n5hif7@gmail.com", password = "test123", username = "z3n5hif7" });
            TestList.Add(new UserModel() { id = 2, email = "billylu_10@ymail.com", password = "test123", username = "Billy Lu" });
            TestList.Add(new UserModel() { id = 3, email = "johndoe@gmail.com", password = "test123", username = "John Doe" });
            TestList.Add(new UserModel() { id = 4, email = "xamarinforms@gmail.com", password = "test123", username = "Xamarin Forms" });
            TestList.Add(new UserModel() { id = 5, email = "windows11@gmail.com", password = "test123", username = "Windows Eleven" });

            LVVM.ContactsList.Add(new Contact() {Id = 1, Email = "johndoe@gmail.com", Username = "John Doe" });
            LVVM.ContactsList.Add(new Contact() {Id = 2, Email = "zenshift357@gmail.com", Username = "Zen Shift" });
            LVVM.ContactsList.Add(new Contact() {Id = 3, Email = "janedoe@gmail.com.com", Username = "Jane Doe" });

            ContactList.Add(new ContactModel() {id = 1, email = "johndoe@gmail.com", username = "John Doe" });
            ContactList.Add(new ContactModel() { id = 2, email = "z3n5hif7@gmail.com", username = "Zen Shift" });

            //LVVM.ContactsList = 

            //LVVM.ContactsList = ContactList;

            InitializeComponent();

            //if(Application.Current.Properties.ContainsKey("Email") && Application.Current.Properties.ContainsKey("Password"))
            if(Application.Current.Properties.ContainsKey("Email") && Application.Current.Properties.ContainsKey("Username") && Application.Current.Properties.ContainsKey("Password"))
            {
                Application.Current.MainPage = new TabbedPage(Application.Current.Properties["Email"].ToString(), Application.Current.Properties["Username"].ToString());
            }
            else
            {   
                MainPage = new MainPage();
            }
            
        }
        //public static ObservableCollection<UserModel> TestList { get; set; } = new ObservableCollection<UserModel>();



        /*public class DataClass
        {
            public static ObservableCollection<UserModel> UserList { get; set; } = new ObservableCollection<UserModel>();

        }*/
        //public ObservableCollection<UserModel> USERS { get; set; } = new ObservableCollection<UserModel>();
        //public MyClass MyProperty { get; set; }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
