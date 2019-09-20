using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Week8.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Week8.ViewModels
{
    public class DeviceViewModelPage : INotifyPropertyChanged
    {
        public ICommand GetDeviceCommand { get; set; }

        public string ShowData { get; set; }
        public DeviceViewModelPage()
        {

            GetDeviceCommand = new Command(() =>
            {
                IDeviceOrientationService service = DependencyService.Get<IDeviceOrientationService>();
                DeviceOrientation orientation = service.GetOrientation();

                ShowData = orientation.ToString();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
