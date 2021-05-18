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
    public partial class WishListPage : ContentPage
    {
        public WishListPage()
        {
            InitializeComponent();
        }

        void SetIsEnabledButtonState(bool startButtonState, bool cancelButtonState)
        {
            startButton.IsEnabled = startButtonState;
            cancelButton.IsEnabled = cancelButtonState;
        }

        private async void StartAnimation_Clicked(object sender, EventArgs e)
        {
            SetIsEnabledButtonState(false, true);

            bool isCancelled = await image.ScaleTo(2, 2000);
            if (!isCancelled)
            {
                await image.ScaleTo(1, 2000);
            }

            SetIsEnabledButtonState(true, false);
        }

        private void CancelAnimation_Clicked(object sender, EventArgs e)
        {
            ViewExtensions.CancelAnimations(image);
            SetIsEnabledButtonState(true, false);
        }
    }
}