using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestAppRestaurant.Models
{
    public class FoodModel
    {
        [Key]
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public decimal Rate { get; set; }
        
    }
}