using System;
using System.Collections.Generic;

#nullable disable

namespace JoePizzaPortal.Models
{
    public partial class Pizza
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public string PizzaImageLink { get; set; }
        public string PizzaDescription { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Order order { get; set; } 
    }
}
