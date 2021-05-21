using RPSStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RPSStore.ViewModels
{
    class EmailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        const int RefreshDuration = 2;
       
        readonly Random random;
        bool isRefreshing;
        bool isChecked;
        public EmailViewModel()
        {

                random = new Random();
                Emails = new ObservableCollection<Email>();
                AddItems();
            
        }

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked= value;
                OnPropertyChanged();
            }
        }
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            isChecked = true; 
        }

        public ObservableCollection<Email> Emails { get; private set; }

        public ICommand RefreshCommand => new Command(async () => await 
        RefreshItemsAsync());

        private async Task RefreshItemsAsync()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(RefreshDuration));
            AddItems();
            IsRefreshing = false;
            IsChecked = true;
        }

        private void AddItems()
        {
            for (int i = 0; i < new Random().Next(100); i++)
            {
                Emails.Add(new Email
                {
                    From="From"+i,To="To"+i,Subject="Subject"+i,Body="Body"+i,IsChecked=false

                });
            }
        }
    }
    
}
