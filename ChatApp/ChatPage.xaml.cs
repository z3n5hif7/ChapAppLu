using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ChatApp;
using Android.Widget;
using Xamarin.Forms.Internals;
using System.Collections.ObjectModel;

namespace ChatApp
{


    public partial class ChatPage: ContentPage
    {
        //public event EventHandler Completed;

        public ChatPage()
        {

            InitializeComponent();
            Visible.IsVisible = false;
            ContactListView.ItemsSource = App.LVVM.ContactsList;
            if (App.LVVM.ContactsList.Count > 0)
            {
                NoContactsMessage.IsVisible = false;
            }
            else
            {

            }

            foreach (var contact in App.LVVM.ContactsList)
            {
                Console.WriteLine(contact.Email);
            }
            /*for (int i = 0; i < App.LVVM.ContactsList.Count; i++)
            {
                Console.WriteLine(App.LVVM.ContactsList.);
            }*/
        }

        private void CheckInput(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Email.Text)) {
                Visible.IsVisible = true;
            }
            else
            {
                Visible.IsVisible = false;
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            Visible.IsVisible = false;
            Email.Text = null;
        }



        private async void Email_Completed(object sender, EventArgs e)
        {

            //UserModel Last = App.TestList.Last();
            UserModel Found = null;
            //Console.WriteLine(Email.Text);
            //App.Try
            //App.DataClass.UserList.
           //ChatApp.App.User
            //Console.WriteLine("Entered");

            if (string.IsNullOrEmpty(Email.Text))
            {
                
                //Console.WriteLine("Entered");
                _ = DisplayAlert("Error", "Missing fields", "OKAY");
                //error message
            }
            else
            {
                //Console.WriteLine("QWE");
                foreach (var x in App.TestList)
                {
               
                    if (x.email.Equals(Email.Text))
                    {
                        Found = x;
                        //Console.WriteLine("EMail found!");
                        break;
                    }
                    else
                    {
                        continue;
                        //Console.WriteLine("Not found!");
                    }
                }

                if (Found != null)//found not found
                {
                    await Navigation.PushModalAsync(new ContactFound(Found), true);
                    //Xamarin.Forms.Application.Current.MainPage = new ContactFound();
                    if (App.ContactList.Count > 0)
                    {
                        NoContactsMessage.IsVisible = false;
                    }
                    else
                    {

                    }
                }
                else
                {
                    _ = DisplayAlert("","User not found.", "OKAY");
                }
            }
        }

        public object SelectedItem { get; set; }
        public async void GoToConversationPage(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

            int contactIndex = e.ItemIndex+1;
            //Console.WriteLine("=!=!=!=!=!=!=!=!=!=!=!=");

            //Console.WriteLine(contactIndex);

            //String Name = null;
            ContactModel.Contact Test = new ContactModel.Contact();
            foreach (var contact in App.LVVM.ContactsList)
            {
                if(contact.Id == contactIndex)
                {
                    //new Contact() { Id = 2, Username = "John Doe", Email = "johndoe@gmail.com" },
                    //Console.WriteLine(contact.Email);
                    Test = new ContactModel.Contact() { Id = contact.Id, Username = contact.Username, Email = contact.Email };
                    //Name = contact.Username;
                }
            }

            await Navigation.PushModalAsync(new ConversationPage(Test), true);
            
        }

        /*public void InvokeCompleted()
        {
            Completed?.Invoke(this, null);
        }*/

        //private async void SignUp_Tapped(object sender, EventArgs e)
        //{
        //await Navigation.PushModalAsync(new SignUp(), true);
        //await Navigation.PushAsync(new SignupPage(), false);
        //}
    }
}
