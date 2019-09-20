using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Week8.Controls
{
    public class ExtendedEntry : Entry
    {
        public static readonly BindableProperty HasBackgraoundSeeted =
       BindableProperty.Create(nameof(HasBackGroundSettedProperty), typeof(bool), typeof(ExtendedEntry), false, BindingMode.TwoWay);

        public bool HasBackGroundSettedProperty
        {
            get
            {
                return (bool)GetValue(HasBackgraoundSeeted);
            }
            set
            {
                SetValue(HasBackgraoundSeeted, value);
            }
        }
    }
}
