using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.PlatformConfiguration;
using System.Collections.ObjectModel;

//using ChatApp;

namespace ChatApp
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage : Xamarin.Forms.TabbedPage
    {
        public TabbedPage()
        {
            InitializeComponent();

            this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            //On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }

        //public TabbedPage(string email, string username, ObservableCollection<UserModel> UserList)
        public TabbedPage(string email, string username)
        {
            InitializeComponent();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            ProfilePage.Email = email;
            ProfilePage.Username = username;
            this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
        }



        /*public void ShowPassword(object sender, EventArgs e)
        {
            if (Password.IsPassword==true)S
            {
                Password.IsPassword = false;
                Visible.Text = "Hide";
            }
            else
            {
                Password.IsPassword = true;
                Visible.Text = "Show";
            }
        }*/

        //public void SignIn(object sender, EventArgs e)
        //{
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
                //Email.Text = null;
                //Password.Text = null;
            //}
        //}

        //private async void SignUpPage(object sender, EventArgs e)
        //{
            //await Navigation.PushModalAsync(new SignUp(), true);
            //await Navigation.PushAsync(new SignupPage(), false);
        //}
    }
}
