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
    public partial class About : ContentPage
    {
        public About()
        {
            InitializeComponent();
        }
       
        private void SecondPageBtn_Clicked(object sender, EventArgs e)
        {
            //var Page = new MasterDetailPage1();
            //NavigationPage.SetHasNavigationBar(Page, false);

            //Navigation.PushAsync(Page);
            Navigation.PopAsync();


        }
    }
}