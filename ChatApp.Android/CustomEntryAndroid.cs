using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ChatApp;
using ChatApp.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly:ExportRenderer(typeof(CustomEntry),typeof(CustomEntryAndroid))]
namespace ChatApp.Droid
{
    //[Obsolete]
    public class CustomEntryAndroid : EntryRenderer
    //public class CustomEntryAndroid(Context context): EntryRenderer(context)
    {
        public CustomEntryAndroid(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement == null)
            {
                GradientStrokeDrawable gradientDrawable = new GradientStrokeDrawable();
                gradientDrawable.SetCornerRadius(20);
                //gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
                gradientDrawable.SetStroke(10, Android.Graphics.Color.Black);
                gradientDrawable.SetColor(Android.Graphics.Color.White);
                Control.SetBackground(gradientDrawable);

                //Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }else
            {
                GradientStrokeDrawable gradientDrawable = new GradientStrokeDrawable();
                gradientDrawable.SetCornerRadius(20);
                //gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
                gradientDrawable.SetStroke(10, Android.Graphics.Color.Red);
                gradientDrawable.SetColor(Android.Graphics.Color.White);
                Control.SetBackground(gradientDrawable);
            }
        }

        public void InvalidInput(ElementChangedEventArgs<Entry> e)
        {
            GradientStrokeDrawable gradientDrawable = new GradientStrokeDrawable();
            gradientDrawable.SetCornerRadius(20);
            //gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
            gradientDrawable.SetStroke(10, Android.Graphics.Color.Red);
            gradientDrawable.SetColor(Android.Graphics.Color.White);
            Control.SetBackground(gradientDrawable);
        }
    }
}