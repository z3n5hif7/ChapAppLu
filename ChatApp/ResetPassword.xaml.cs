using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChatApp
{
    public partial class ResetPassword: ContentPage
    {
        public ResetPassword()
        {
            InitializeComponent();
            _ = Xamarin.Forms.Keyboard.Email;
        }



        private void Back(Object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage = new MainPage();
            Xamarin.Forms.Application.Current.SavePropertiesAsync();
        }

        public void ResetEmail(Object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Email.Text))
            {
                //Xamarin.Forms.Application.Current.Properties["Email"] = Email.Text;
                //Xamarin.Forms.Application.Current.SavePropertiesAsync();

                //Xamarin.Forms.Application.Current.MainPage = new TabbedPage(Email.Text, Password.Text);
                DisplayAlert("Success", "Email has been sent to your email address.", "OKAY");
            }
            else
            {
                DisplayAlert("Error", "Missing field", "OKAY");
                /*bool retry = await DisplayAlert("Error", "Please fill in all fields. Retry?", "Yes", "No");
                if (retry)
                {
                    Email.Text = string.Empty;
                    Password.Text = string.Empty;
                    //Email.Focus();
                }*/


            }
        }

        //private async void SignUp_Tapped(object sender, EventArgs e)
        //{
        //await Navigation.PushModalAsync(new SignUp(), true);
        //await Navigation.PushAsync(new SignupPage(), false);
        //}
    }
}
