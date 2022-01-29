using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  CartInsta.Models{

    public class Order{
        public int OrderID {get; set;}                          //primary Key
        public string ProductName {get; set;} = string.Empty;   // needs to be a list in the future
        public string CustomerName {get; set;} = string.Empty;  
        public double OrderTotal {get; set;}                       
        
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]      
        public static DateTime OrderDate { get; set;}

        [DataType(DataType.Date)]
        [Display(Name = "Delivery Date")]  
        public DateTime DeliveryDate {get; set;}
    }
}