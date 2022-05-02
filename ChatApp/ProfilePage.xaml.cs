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
    public partial class ProfilePage: ContentPage
    {
        //[XamlCompilation(XamlCompilationOptions.Compile)]
        public ProfilePage()
        {
            InitializeComponent();

        }

        public static readonly BindableProperty EmailProperty = BindableProperty.Create(nameof(Email), typeof(string), typeof(ProfilePage), "");

        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        public static readonly BindableProperty UsernameProperty = BindableProperty.Create(nameof(Username), typeof(string), typeof(ProfilePage), "");

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        /*public ProfilePage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }*/

        private void SignOut(Object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.Properties.Remove("Email");
            Xamarin.Forms.Application.Current.Properties.Remove("Username");


            Xamarin.Forms.Application.Current.MainPage = new MainPage();
            Xamarin.Forms.Application.Current.SavePropertiesAsync();
        }


        //private async void SignUp_Tapped(object sender, EventArgs e)
        //{
        //await Navigation.PushModalAsync(new SignUp(), true);
        //await Navigation.PushAsync(new SignupPage(), false);
        //}
    }
}
