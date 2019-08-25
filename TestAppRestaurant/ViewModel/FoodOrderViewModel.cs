using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestAppRestaurant.Models;

namespace TestAppRestaurant.ViewModel
{
    public class FoodOrderViewModel
    {
        [Key]
        public int FoodOrderID { get; set; }
        [Display(Name = "Food Name")]
        [Required(ErrorMessage = "This field is required")]
        public string FoodName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Quantity { get; set; }

        public decimal Price { get; set; }
        [Display(Name = "Service Charge")]
        public decimal ServiceCharge { get; set; }
        public decimal VAT { get; set; }
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
        [Display(Name = "Ordered Date")]
        public DateTime OrderedDate { get; set; }
        [Display(Name = "Delivery Status")]
        public bool IsDelivered { get; set; }
    }
}