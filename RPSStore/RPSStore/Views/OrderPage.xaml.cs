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

        private async void OnQuestion1ButtonClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "What's your name?", initialValue: string.Empty);
            if (!string.IsNullOrWhiteSpace(result))
            {
                question1ResultLabel.Text = $"Hello {result}.";
            }
        }

        private async void OnQuestion2ButtonClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "What's your SSN?", initialValue: "10", maxLength: 15, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                long number = Convert.ToInt64(result);
                question2ResultLabel.Text = number >  100000000 ? "Correct." : "Incorrect.";
            }
        }
    }
}