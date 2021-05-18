using System;
using System.Collections.Generic;
using System.Text;

namespace RPSStore.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public String Name { get; set; }
        public String Brand { get; set; }
        public String ImageName { get; set; }
    }
}
