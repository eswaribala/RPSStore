using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RPSStore.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            Title = "Order";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}