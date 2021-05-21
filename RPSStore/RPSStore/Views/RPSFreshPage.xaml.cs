using RPSStore.Models;
using RPSStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPSStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RPSFreshPage : ContentPage
    {
        private ObservableCollection<Email> Emails;
        private EmailViewModel vm;
        public RPSFreshPage()
        {
            InitializeComponent();
            vm = new EmailViewModel();
            this.BindingContext = vm;
            Emails = new EmailViewModel().Emails;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            foreach (Email email in Emails)
            {
                email.IsChecked = false;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Frame frame = (Frame)sender;
            CheckBox chkBox = (CheckBox)((sender as Frame).FindByName("chkBox"));
            chkBox.IsChecked = true;
            DisplayAlert("Message", "Tapped", "Cancel");


        }
        /*
        private void TapGestureRecognizerNew_Tapped(object sender, EventArgs e)
        {
            Frame frame = (Frame)sender;
            CheckBox chkBox = (CheckBox)((sender as Frame).FindByName("chkBox"));
            chkBox.IsChecked = true;
            DisplayAlert("Message", "Tapped", "Cancel");
        }
        */

    }
    }