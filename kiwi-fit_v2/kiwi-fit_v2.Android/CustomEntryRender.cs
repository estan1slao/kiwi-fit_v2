using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using kiwi_fit_v2.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.Reflection;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRender))]
namespace kiwi_fit_v2.Droid
{
     public class CustomEntryRender: EntryRenderer
     {
        public CustomEntryRender(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null) 
            { 
                Control.Background = null;
            }
        }
     }
}