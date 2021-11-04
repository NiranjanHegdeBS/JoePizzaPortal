using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoePizzaPortal.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        [StringLength(12, MinimumLength= 12, ErrorMessage = "Card Number must be 12 Digit Number")]
        public string CardNumber { get; set; }
        public int OrderQuantity { get; set; }
        public double TotalAmount { get; set; }
        public string PizzaType { get; set; }

        [Required(ErrorMessage = "Shipping Address is Required!")]
        public string ShippingAddress { get; set; }
        //Foreign Key
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime transactionTime { get; set; }
    }
}
