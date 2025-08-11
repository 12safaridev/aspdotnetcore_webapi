using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace restaurantAPI.Models
{
    public class Customer
    {
        //     []
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } 
    }
}