using RPSStore.Models;
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
        private String Gender { get; set; }
        private bool PhoneNo { get; set; }
        private bool Email { get; set; }
        private bool WhatsApp { get; set; }
        private bool FaceBook { get; set; }
        public RPSBusinessPage()
        {
            InitializeComponent();
        }

        private void OnGenderRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            Gender = radioButton.Content.ToString();
        }

        private void Contact_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.FirstName = FirstName.Text;
            contact.LastName = LastName.Text;
            contact.Gender = Gender;
            List<Boolean> modes = new List<Boolean>();
            modes.Add(PhoneNo);
            modes.Add(Email);
            modes.Add(WhatsApp);
            modes.Add(FaceBook);
            contact.ContactModes = modes;
            DisplayAlert("Received", contact.ContactModes.Count.ToString(), "OK");

        }

        private void phoneNoCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            PhoneNo = true;
        }

        private void emailCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Email = true;
        }

        private void WhatsAppCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            WhatsApp = true;
        }

        private void facebookCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            FaceBook = true;
        }

       
    }
}