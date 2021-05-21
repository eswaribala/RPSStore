using RPSStore.Models;
using RPSStore.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PayPage : ContentPage
    {
        //float progress = 0f;

        public ObservableCollection<int> ProgressValue { get; set; }
        public ObservableCollection<Photo> Photos { get; set; }
        public PayPage()
        {
            InitializeComponent();
            LoadData();
        }




        private async void LoadData()
        {
            APIAccess apiAccess = new APIAccess();
            Photos = await apiAccess.GetPhotos();
            ProgressValue = apiAccess.ProgressValue;
            
        }
        private async void Call_Clicked(object sender, EventArgs e)
        {
            bool status = true;
            string sPattern = "^\\d{3}-\\d{3}-\\d{4}$";
            if (!string.IsNullOrEmpty(PhoneNo.Text)) {
                status = false;
                if (Regex.IsMatch(PhoneNo.Text, sPattern))
                {

                    status = false;
                    await Call(PhoneNo.Text);
                }
                
            }

            if (status)
            {
                await this.Navigation.PopAsync();
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

        private async void Button_Clicked(object sender, EventArgs e)

        {
           
            progressbar.Progress = ProgressValue.Count;
            await progressbar.ProgressTo(ProgressValue.Count, 100, Easing.Linear);

            /*
            
            if (ProgressValue.Count > 0)
            {
                var list = new List<int>(ProgressValue);
                foreach (int value in list)
                {
                    if (value > 0)
                    {
                        progressbar.Progress = value;
                      
                    }
                    }
            }
            */
            // directly set the new progress value

            // animate to the new value over 750 milliseconds using Linear easing


        }
    }
}