using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  CartInsta.Models {
    public class User
    {
        public int UserID {get; set;}                           //primary Key

        [Required]
        [StringLength(50)]
        public string FirstName {get; set;} = string.Empty;    
        [Required]
        [StringLength(50)]
        public string LastName {get; set;} = string.Empty;

        [Required]
        [StringLength(50)]
        public string UserName {get; set;} = string.Empty;

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        [DataType(DataType.Date)]
        [Display(Name = "Birth Day")]   
             
        public DateTime BirthDay {get; set;}
        
        public long Phone {get; set;}

        public ICollection<Order> Orders { get; set; } //navigation property
        
    }
}