using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AkijFood.Models
{
    public class FoodClass
    {
        [Key]
        public int IntColdDrinkId { get; set; }

        [Required(ErrorMessage ="enter cold drinks name")]
        [Display(Name = "Drinks Name")]

        public string StrColdDrinksName { get; set; }

        [Required(ErrorMessage ="enter quantity")]
        [Display(Name = "Quantity")]

        public decimal NumQuantity { get; set; }

        [Required(ErrorMessage ="Enter price of the drinks")]
        [Display(Name = "Unit price")]

        public decimal NumUnitPrice { get; set; }

        public class nec
        {
        }
    }
}
