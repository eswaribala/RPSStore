using RPSStore.Data;
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
    [QueryProperty(nameof(Name), "name")]
    public partial class CategoryDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                LoadCategory(value);
            }
        }
        public CategoryDetailPage()
        {
            InitializeComponent();
        }
        void LoadCategory(string name)
        {
            try
            {
                Category category = CategoryData.Categories.FirstOrDefault(a => a.Name == name);
                Console.WriteLine("Detail" + category.ImageUrl);
                BindingContext = category;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load photo.");
            }
        }
    }
}