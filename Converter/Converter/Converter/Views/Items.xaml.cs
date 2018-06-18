using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Converter.ViewModels;
using System.Collections.ObjectModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Converter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Items : ContentPage
    {
        public ObservableCollection<ItemsDetail> elements { get; set; }
        public ObservableCollection<ItemsDetail> el { get; set; }
        private ItemsDetail eDetail;


        public Items()
        {
            InitializeComponent();
            elements = new ObservableCollection<ItemsDetail>
            {
                new ItemsDetail
                {
                    Name = "Dolar amerykanski",
                    ShortName = "USD",
                    Country = "USA",
                    Cost = 5,
                    ImageUrl = "usa.jpg",
                },
                new ItemsDetail
                {
                    Name = "Euro",
                    ShortName = "EUR",
                    Country = "Anglia",
                    Cost = 4,
                    ImageUrl = "usa.jpg",

                },
                new ItemsDetail
                {
                    Name = "Zlotowka",
                    ShortName = "PLN",
                    Country = "Polska",
                    Cost = 1,
                    ImageUrl = "usa.jpg",

                },
                new ItemsDetail
                {
                    Name = "Dolar szwajcarski",
                    ShortName = "CHF",
                    Country = "Szwajcaria",
                    Cost = 3,
                    ImageUrl = "usa.jpg",

                }
            };
            CurrencyListView.ItemsSource = elements;
            CurrencyListView2.ItemsSource = elements;


        }

        public void OnItemSelected1(object o, ItemTappedEventArgs e)
        {
           
           eDetail = (ItemsDetail) e.Item;
           FirstLabel.Text = eDetail.Name;
           FirstLabelShort.Text = eDetail.ShortName;
           FirstEntry.Text = (eDetail.Cost).ToString();
        }
        public void OnItemSelected2(object o, ItemTappedEventArgs e)
        {

            eDetail = (ItemsDetail)e.Item;
            SecoundLabel.Text = eDetail.Name;
            SecoundLabelShort.Text = eDetail.ShortName;
            SecoundEntry.Text = (eDetail.Cost).ToString();
        }
        private void HomePageBtn_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PopAsync();
        }

        private void FirstEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {

           // SecoundEntry.Text= (float.Parse(e.NewTextValue) * eDetail.Cost).ToString();
        }

        private void SecoundEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Changer_OnClickedBtn_Clicked(object sender, EventArgs e)
        {
            SecoundLabel.Text = FirstLabel.Text;
            SecoundLabelShort.Text = FirstLabelShort.Text;

            FirstLabel.Text = SecoundLabel.Text;
            FirstLabelShort.Text = SecoundLabelShort.Text;
        }
    }
}