using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week8.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DevicePage : ContentPage
    {
        public DevicePage()
        {
            InitializeComponent();
            this.BindingContext = new DeviceViewModelPage();
        }
    }
}