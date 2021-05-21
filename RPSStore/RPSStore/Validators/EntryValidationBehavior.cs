using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace RPSStore.Validators
{
    public class EntryValidationBehavior:Behavior<Entry>
    {
        const String firstNameRegEx = @"^[A-Za-z]{5,50}$";
        public static readonly BindableProperty IsValidProperty =
            BindableProperty.Create(nameof(IsValid),typeof(bool),typeof(EntryValidationBehavior),false,BindingMode.OneWay);
    
        public bool IsValid
        {
            get
            {
                return (bool)GetValue(IsValidProperty);


            }
            set
            {
                SetValue(IsValidProperty,value);
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

        public void HandleTextChanged(Object sender,TextChangedEventArgs e)
        {
            // var isValid = !string.IsNullOrWhiteSpace(e.NewTextValue);
            var isValid = Regex.IsMatch(e.NewTextValue, firstNameRegEx);
            IsValid = isValid;
            ((Entry)sender).BackgroundColor = IsValid ? Color.Default : Color.Red;

        }

    }
}
