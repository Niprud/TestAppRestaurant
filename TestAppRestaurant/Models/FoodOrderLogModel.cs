using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestAppRestaurant.Models
{
    public class FoodOrderLogModel
    {
        [Key]
        public int FoodOrderID { get; set; }
        public FoodModel FoodName { get; set; }
        public int Quantity { get; set; }     
        public decimal Price { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderedDate { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime EditedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public string EditedBy { get; set; }
        public string DeletedBy { get; set; }

    }
}