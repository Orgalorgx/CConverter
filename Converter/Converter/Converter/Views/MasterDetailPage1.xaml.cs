using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Converter.Views;

using Xamarin.Forms.Xaml;

namespace Converter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            Detail = new TabbedPage
            {

                Children =
            {
                new NavigationPage(new Items())
                {
                    Title = "All currency",
                    Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                },
                new NavigationPage(new Graphs())
                {
                    Title = "Graphs",
                    Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                },
                new NavigationPage(new Favourites())
                {
                    Title = "Favourites",
                    Icon = Device.OnPlatform<string>("tab_feed.png",null,null)

                },
            }
            };
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

            Detail = new NavigationPage(new About());           

            IsPresented = false;
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Settings());
            IsPresented = false;

        }
    }
}