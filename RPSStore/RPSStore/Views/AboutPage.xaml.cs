using RPSStore.Data;
using RPSStore.Models;
using RPSStore.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSStore.Views
{
    public partial class AboutPage : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }
        public CarouselViewModel VM;
        public AboutPage()
        {
            InitializeComponent();
            
            NavigateCommand = new Command<Type>(
               async (Type pageType) =>
               {
                   Page page = (Page)Activator.CreateInstance(pageType);
                   await Navigation.PushAsync(page);
               });
           // VM = new CarouselViewModel();
            BindingContext = this;
            CatView.ItemsSource = new CarouselViewModel().Categories;
        }

        
    }
}