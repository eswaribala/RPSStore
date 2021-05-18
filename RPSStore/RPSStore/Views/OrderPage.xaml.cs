using RPSStore.Models;
using RPSStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        List<Product> products;
        public OrderPage()
        {
            InitializeComponent();
            SetupData();
            listView.ItemsSource = products;
        }
        
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var detailPage = new OrderDetailPage();
                detailPage.BindingContext = e.SelectedItem as Product;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

		void SetupData()
		{
            products = new ProductViewModel().Products;
			
		}
	}
}