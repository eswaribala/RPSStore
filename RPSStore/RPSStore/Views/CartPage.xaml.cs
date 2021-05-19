using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
        }

        private async void GetLocation_Clicked(object sender, EventArgs e)
        {
            try
            {
                var yourLocation = await Geolocation.GetLocationAsync(new GeolocationRequest()
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });

                if (yourLocation == null)
                    await DisplayAlert("Attention", "GPS is not available", "Ok");
                else
                    YourLocationLatitude.Text = $"{yourLocation.Latitude}";
                YourLocationLongitude.Text = $"{yourLocation.Longitude}";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ooops!", $"Something went wrong: {ex.Message}", "Ok");
            }
        }

        private async void GoToMap_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Map.OpenAsync(double.Parse(YourLocationLatitude.Text), double.Parse(YourLocationLongitude.Text), new MapLaunchOptions
                {
                    Name = "Your location",
                    NavigationMode = NavigationMode.None
                });
            }
            catch (Exception ex1)
            {
                await DisplayAlert("Ooops!", $"Remenber to search your coordinates, first.", "Ok");
            }
        }
    }
}