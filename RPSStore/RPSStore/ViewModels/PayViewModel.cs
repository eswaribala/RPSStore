using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RPSStore.ViewModels
{
    public class PayViewModel : BaseViewModel
    {
        public PayViewModel()
        {
            Title = "Pay";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}