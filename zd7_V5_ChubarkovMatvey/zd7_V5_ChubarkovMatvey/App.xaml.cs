using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd7_V5_ChubarkovMatvey
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SwipePage());
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
