using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Week8.Controls;
using Week8.iOS.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryRender))]
namespace Week8.iOS.Renders
{

    public class ExtendedEntryRender : EntryRenderer
    {
        public ExtendedEntryRender()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null && ((ExtendedEntry)Element).HasBackGroundSettedProperty)
                Control.BackgroundColor = UIColor.Red;
        }
    }
}