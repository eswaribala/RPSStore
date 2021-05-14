using RPSStore.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RPSStore.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}