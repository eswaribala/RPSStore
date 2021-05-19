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
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool status = await DisplayAlert("Notification", "Do you want store this Number ?", "Yes", "No");
            if (status)
            {
                await this.Navigation.PushAsync(new CategoryPage());
            }
            else
            {
                await this.Navigation.PopAsync();
            }

        }
    }
}