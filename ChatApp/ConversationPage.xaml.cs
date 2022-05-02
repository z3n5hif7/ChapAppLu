using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace ChatApp
{
    public partial class ConversationPage: ContentPage
    {
        public ConversationPage()
        {
            InitializeComponent();
        }

        /*public ConversationPage(String username, String email)
        {
            InitializeComponent();

        }*/

        public ConversationPage(ContactModel.Contact User)
        {
            InitializeComponent();
            Email = User.Email;
            Username = User.Username;
        }

        public static readonly BindableProperty EmailProperty = BindableProperty.Create(nameof(Email), typeof(string), typeof(ContactFound), "");

        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        public static readonly BindableProperty UsernameProperty = BindableProperty.Create(nameof(Username), typeof(string), typeof(ContactFound), "");

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        /*public ContactFound(UserModel UM)
        {
            InitializeComponent();
            Email = UM.email;
            Username = UM.username;
            //this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);

        }*/

        /*public async void AddUser(Object sender, EventArgs e)
        {
           bool choice = await DisplayAlert("Add Contact", "Would you like to add " + Username + "?", "YES", "NO");

            if (choice)
            {
                //Console.WriteLine("YES");
                if (Xamarin.Forms.Application.Current.Properties["Email"].Equals(Email))
                {
                    _ = DisplayAlert("Error", "You are not allowed to add your own self.", "OKAY");
                }
                else
                {
                    ContactModel Found = null;
                    if (App.ContactList.Count > 0)
                    {
                        foreach (var x in App.ContactList)
                        {
                            if (x.email.Equals(Email))
                            {
                                Console.WriteLine(x.email);
                                Found = x;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }

                    if(Found==null) //contact not found, add to contactsList
                    {
                        //UserList.Add(new UserModel() { id = 1, email = "z3n5hif7@gmail.com", password = "test123", username = "z3n5hif7" });
                        int i = App.ContactList.Count;
                        i++;
                        //App.ContactList.Add(new ContactModel() {id = i, email = Found.email, username = Found.username });
                        App.ContactList.Add(new ContactModel() {id = i, email = Email, username = Username});
                        _ = DisplayAlert("Success", "Added connection successfully.", "OKAY");
                        Console.WriteLine("START HERE");
                        Console.WriteLine(Email);
                        Console.WriteLine(Username);
                        Console.WriteLine(i);

                        await Navigation.PopModalAsync();
                    }
                    else
                    {
                        Console.WriteLine("IM HERE!?");

                        _ = DisplayAlert("Failed", "You both already have a connection.", "OKAY");
                    }
                }
            }
            else
            {
                //Console.WriteLine("NO");

            }
        }*/

        public async void ExitClicked(Object sender, EventArgs e) {
            await Navigation.PopModalAsync();
        }
    }
}
