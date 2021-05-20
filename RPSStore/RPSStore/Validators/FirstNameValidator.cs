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
            bool IsValid = false;
            IsValid=Regex.IsMatch(e.NewTextValue, firstNameRegEx);
            ((Entry)sender).TextColor = IsValid ? Color.Default : Color.Red;
        }
    }
}
