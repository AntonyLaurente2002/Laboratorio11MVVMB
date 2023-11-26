using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab11MVVMB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.Sueldo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
