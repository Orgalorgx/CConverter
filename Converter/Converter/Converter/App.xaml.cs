using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Converter.Views; 

namespace Converter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var Page = new MasterDetailPage1();
            MainPage = Page;
            
        }       

        protected override void OnStart()
        {

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
