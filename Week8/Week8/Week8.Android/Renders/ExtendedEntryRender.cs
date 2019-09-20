using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Week8.Controls;
using Week8.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRender))]
namespace Week8.Droid.Renders
{
    public class ExtendedEntryRender : EntryRenderer
    {
        public ExtendedEntryRender(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null&& ((ExtendedEntry)Element).HasBackGroundSettedProperty)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Red);
            }
        }
    }
}