using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using ChatApp;
//using Android.Widget;
using ChatApp.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonAndroid))]

namespace ChatApp.Droid
{
    class CustomButtonAndroid : ButtonRenderer
    {
        public CustomButtonAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            CustomButton elem = Element as CustomButton;
            Control.SetAllCaps(elem.AutoCapitalization);
        }

    }
}