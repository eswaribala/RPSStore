﻿using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RPSStore.ViewModels
{
    public class BuyAgainViewModel : BaseViewModel
    {
        public BuyAgainViewModel()
        {
            Title = "Buy Again";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}