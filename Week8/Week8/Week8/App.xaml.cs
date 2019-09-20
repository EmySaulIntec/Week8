using System;
using Week8.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week8
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DevicePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
