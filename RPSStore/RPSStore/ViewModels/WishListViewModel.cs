using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RPSStore.ViewModels
{
    public class WishListViewModel : BaseViewModel
    {
        public WishListViewModel()
        {
            Title = "Wish List";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}