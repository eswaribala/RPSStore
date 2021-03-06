using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Text.RegularExpressions;
namespace RPSStore.Validators
{
   public class FirstNameValidator:Behavior<Entry>
    {
        const String firstNameRegEx = @"^[A-Za-z]{5,50}$";
        public static readonly BindableProperty IsValidProperty =
           BindableProperty.Create(nameof(IsValid), typeof(bool), typeof(EntryValidationBehavior), false, BindingMode.OneWay);

        public bool IsValid
        {
            get
            {
                return (bool)GetValue(IsValidProperty);


            }
            set
            {
                SetValue(IsValidProperty, value);
            }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += HandleTextChanged;
            base.OnAttachedTo(bindable);
        }
      
        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged += HandleTextChanged;
            base.OnDetachingFrom(bindable);
        }
        private void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            // IsValid = false;
            var isValid=Regex.IsMatch(e.NewTextValue, firstNameRegEx);
            IsValid = isValid;
            ((Entry)sender).BackgroundColor = IsValid ? Color.Default : Color.Red;
        
        }
    }
}
