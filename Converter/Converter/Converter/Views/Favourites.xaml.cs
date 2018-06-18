using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Converter.Views;

namespace Converter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favourites : ContentPage
    {
        public Favourites()
        {
            InitializeComponent();
            CurrencyListView.ItemsSource = Converter.Helpers.Settings.myIntList;

        }
    }
}