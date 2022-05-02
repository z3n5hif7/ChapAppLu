using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ChatApp;
using System.Collections.ObjectModel;

namespace ChatApp
{
    public partial class MainPage : ContentPage
    {
        //public List<string> Emails = new List<string> { };
        //public List<UserModel> userss = new List<UserModel> { };

        public static ObservableCollection<UserModel> UserList { get; set; } = new ObservableCollection<UserModel>();

        public MainPage()
        {
            InitializeComponent();
            UserList.Add(new UserModel() { id  = 1 , email = "z3n5hif7@gmail.com", password = "test123", username="z3n5hif7"});

        }

        public void ShowPassword(object sender, EventArgs e)
        {
            if (Password.IsPassword==true)
            {
                Password.IsPassword = false;
                Visible.Text = "Hide";
            }
            else
            {
                Password.IsPassword = true;
                Visible.Text = "Show";
            }
        }

        public void SignIn(object sender, EventArgs e)
        {
            
            //CustomEntry.
            //ChatApp.CustomEntry.

            //var entry = sender as Entry;
            //if (Password.Text == null || Email.Text == null)
            //{
                /*ChatApp.

                
                Email.BackgroundColor = Color.FromHex("#FF0000");
                Email.Text = null;

                Password.BackgroundColor = Color.FromHex("#FF0000");
                Password.Text = null;*/


                //DisplayAlert("Error", "Missing fields", "OKAY");
                //String color = "Red";
                //Email.Background.ToString();

               // entry.BackgroundColor = Color.Red;
            //}
            //else
            //{
            //    Email.Text = null;
            //    Password.Text = null;
            //}

            if(!string.IsNullOrEmpty(Email.Text) && !string.IsNullOrEmpty(Password.Text))
            {
                int i = 0;
                foreach(var x in App.TestList)
                {
                    //Console.WriteLine(Email.Text);
                    //Console.Write(i++);
                    //Console.WriteLine(x.email);
                    //Console.WriteLine(x.email);
                    if (x.email.Equals(Email.Text))
                    {
                        Console.Write(i++);
                        Console.WriteLine(" "+Email.Text);

                        if (x.password.Equals(Password.Text))
                        {
                            Xamarin.Forms.Application.Current.Properties["Email"] = x.email;
                            Xamarin.Forms.Application.Current.Properties["Username"] = x.username;
                            Xamarin.Forms.Application.Current.Properties["Password"] = x.password;
                            Xamarin.Forms.Application.Current.SavePropertiesAsync();
                            Xamarin.Forms.Application.Current.MainPage = new TabbedPage(x.email, x.username);
                            //Xamarin.Forms.Application.Current.MainPage = new TabbedPage(x.email, x.username,UserList);
                        }
                        else
                        {
                            _ = DisplayAlert("Error", "Email or Password incorrect.", "OKAY");
                        }

                    }
                    
                    if(x.email.Equals(null)){
                        _ = DisplayAlert("Error", "Email not verified. Sent another verification email.", "OKAY");
                        //break;
                    }
                }

            }
            else
            {
                _ = DisplayAlert("Error", "Missing fields", "OKAY");
                //bool retry = await DisplayAlert("Error", "Missing fields", "Yes", "No");
                /*if (retry)
                {
                    Email.Text = string.Empty;
                    Password.Text = string.Empty;
                }*/
            }
        }

        public async void ForgotPassword(object sender, EventArgs e)
        {
            Console.WriteLine("Hello guys!");
            await Navigation.PushModalAsync(new ResetPassword(), true);
        }

        /*protected async override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

        }*/

        private async void SignUpPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignUp(), true);
            //await Navigation.PushAsync(new SignupPage(), false);
        }
    }
}
