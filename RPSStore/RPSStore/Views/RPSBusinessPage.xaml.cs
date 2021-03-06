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
    public partial class RPSBusinessPage : ContentPage
    {
        private Contact objContact;
        public RPSBusinessPage()
        {
            InitializeComponent();
            // Customer
            objContact = new Contact();
            this.BindingContext = objContact;
            //his.BindingContext = new ValidationViewModel(this);
        }
       
        private void OnGenderRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            //Gender = radioButton.Content.ToString();
        }
        
        private void Contact_Clicked(object sender, EventArgs e)
        {
            
            Contact contact = new Contact();
            contact.FirstName = FirstName.Text;
            contact.LastName = LastName.Text;
            /*
            contact.Gender = Gender;
            List<Boolean> modes = new List<Boolean>();
            modes.Add(PhoneNo);
            modes.Add(Email);
            modes.Add(WhatsApp);
            modes.Add(FaceBook);
            contact.ContactModes = modes;
            */
            DisplayAlert("Received",contact.FirstName.ToString() , "OK");

        }
        
        private void phoneNoCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
           // PhoneNo = true;
        }

        private void emailCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //Email = true;
        }

        private void WhatsAppCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //WhatsApp = true;
        }

        private void facebookCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //FaceBook = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}