using RPSStore.Data;
using RPSStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace RPSStore.ViewModels
{
    public class CarouselViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Category> _Categories;
        private String _Name,_details;
        public CarouselViewModel()
        {
            _Categories = new ObservableCollection<Category>();

            foreach(Category cat in CategoryData.Categories)
            _Categories.Add(cat);

        }

        public ObservableCollection<Category> Categories
        {
            get
            {
                return _Categories;
            }
            set
            {
                if (_Categories != value)
                {
                    _Categories = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Categories"));
                }
            }


        }

       

       

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
