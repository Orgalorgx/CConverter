using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Converter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void SecondPageBtn_Clicked(object sender, EventArgs e)
        {
            var Page = new MasterDetailPage1();
            Page.Title = "asdas";
           // NavigationPage.SetHasNavigationBar(Page, false);

            Navigation.PushAsync(Page);

        }
        //private void x_Clicked(object sender, EventArgs e)
        //{
        //    var Page = new Page1();
        //    NavigationPage.SetHasNavigationBar(Page, false);
        //    Navigation.PushAsync(Page);

        //}
    }
}