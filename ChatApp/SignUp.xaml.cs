using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChatApp
{
    public partial class SignUp: ContentPage
    {
        public SignUp()
        {
            InitializeComponent();

        }

        public void ShowPassword(object sender, EventArgs e)
        {
            //Console.WriteLine("PASSWORD BUTTON");


            if (Password.IsPassword == true)
            {
                Password.IsPassword = false;
                VisiblePassword.Text = "Hide";
            }
            else
            {
                Password.IsPassword = true;
                VisiblePassword.Text = "Show";
            }
        }

        public void ShowConfirmPassword(object sender, EventArgs e)
        {
            //Console.WriteLine("CONFIRM PASSWORD BUTTON");

            if (ConfirmPassword.IsPassword == true)
            {
                ConfirmPassword.IsPassword = false;
                VisibleConfirmPassword.Text = "Hide";
            }
            else
            {
                ConfirmPassword.IsPassword = true;
                VisibleConfirmPassword.Text = "Show";
            }
        }

        public void SignInClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage = new MainPage();
        }

        public void SignUpClicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Username.Text) && !string.IsNullOrEmpty(Email.Text) && !string.IsNullOrEmpty(Password.Text) && !string.IsNullOrEmpty(ConfirmPassword.Text))
            {
                if (Password.Text.Equals(ConfirmPassword.Text))
                {
                    //Xamarin.Forms.Application.Current.MainPage = new MainPage();
                    //Xamarin.Forms.Application.Current.SavePropertiesAsync();

                    //var success = DisplayAlert("Success", "Sign up successful. Verification email sent.", "OKAY");
                    _ = DisplayAlert("Success", "Sign up successful. Verification email sent.", "OKAY");
                    Xamarin.Forms.Application.Current.MainPage = new MainPage();
                    //NavigationPage.PopAsync(MainPage());

                    //if (success.Equals(true))
                    //{
                    //Xamarin.Forms.Application.Current.MainPage = new MainPage();

                    //Navigation.PopAsync();
                    //Xamarin.Forms.Application.Current.MainPage = new MainPage();
                    //}

                }
                else
                {
                    _ = DisplayAlert("Error", "Password and Confirm Password do not match", "OKAY");

                }
            }
            else
            {
                _ = DisplayAlert("Error", "Missing fields", "OKAY");

            }
        }

        //private async void SignUp_Tapped(object sender, EventArgs e)
        //{
        //await Navigation.PushModalAsync(new SignUp(), true);
        //await Navigation.PushAsync(new SignupPage(), false);
        //}
    }
}
