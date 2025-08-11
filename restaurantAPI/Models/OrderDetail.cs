using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace restaurantAPI.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public string OrderMasterId { get; set; }

        public OrderMaster OrderMaster { get; set; }

        public int FoodItemId { get; set; }

        public FoodItem FoodItem { get; set; }

        public decimal FoodItemPrice { get; set; }

        public int Quantity { get; set; }
    }
}