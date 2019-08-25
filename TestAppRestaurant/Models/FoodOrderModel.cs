using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestAppRestaurant.Models
{
    public class FoodOrderModel
    {
        [Key]
        public int FoodOrderID { get; set; }
        public string FoodName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderedDate { get; set; }
        public bool IsDelivered { get; set; }
    }    
}
