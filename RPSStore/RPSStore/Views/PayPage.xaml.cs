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
    public partial class PayPage : ContentPage
    {
        public PayPage()
        {
            InitializeComponent();
        }

        private async void Call_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PhoneNo.Text))
            {
                await Call(PhoneNo.Text);
            }
        }

        public async Task Call(string number)
        {
            try
            {
                PhoneDialer.Open(number);
            }

            catch (FeatureNotSupportedException ex)
            {
                PhoneNo.Text = "Phone Dialer is not supported on this device.";
            }
            catch (Exception ex)
            {
                // Other error has occurred.  
            }
        }
    }
}