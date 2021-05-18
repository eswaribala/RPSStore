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

        void SetIsEnabledButtonState(bool startButtonState, bool rotateButtonState, bool cancelButtonState)
        {
            startButton.IsEnabled = startButtonState;
            rotateButton.IsEnabled = rotateButtonState;
            cancelButton.IsEnabled = cancelButtonState;
        }

        private async void StartAnimation_Clicked(object sender, EventArgs e)
        {
            SetIsEnabledButtonState(false,false, true);

            bool isCancelled = await image.ScaleTo(2, 2000);
            if (!isCancelled)
            {
                await image.ScaleTo(1, 2000);
            }

            SetIsEnabledButtonState(true,false, false);
        }

        private async void RotateAnimation_Clicked(object sender, EventArgs e)
        {
            SetIsEnabledButtonState(true,false, true);

            bool isCancelled = await image.RotateTo(360, 2000);
            if (!isCancelled)
            {
                await image.RotateTo(0, 2000);
            }

            SetIsEnabledButtonState(false,true, false);
        }
        private void CancelAnimation_Clicked(object sender, EventArgs e)
        {
            ViewExtensions.CancelAnimations(image);
            SetIsEnabledButtonState(true,true, false);
        }
    }
}