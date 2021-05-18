using RPSStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSStore.ViewModels
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public ProductViewModel()
        {
            CreateProductCollection();
        }

        public void CreateProductCollection()
        {
            Products = new List<Product>();
            Products.Add(new Product
            {
                ProductId = 1,
                Name = "Cell Phone",
                Brand = "Amazon",
                ImageName = "cellphone.jpg"
            });
            Products.Add(new Product
            {
                ProductId = 2,
                Name = "Oxygen Meter",
                Brand = "Amazon",
                ImageName = "oxygenmeter.jpg"
            });
            Products.Add(new Product
            {
                ProductId = 3,
                Name = "Alexa",
                Brand = "Amazon",
                ImageName = "alexa.jpg"
            });
            Products.Add(new Product
            {
                ProductId = 4,
                Name = "Head Phone",
                Brand = "Amazon",
                ImageName = "headphones.jpg"
            });

        }


    }
}
