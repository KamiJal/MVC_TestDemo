using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestDemo.Utils;

namespace TestDemo.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = AppStrings.ErrorMessages.Required)]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = AppStrings.ErrorMessages.Required)]
        [Display(Name = AppStrings.DisplayNames.Manufacturer)]
        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }

        [Required(ErrorMessage = AppStrings.ErrorMessages.Required)]
        [Display(Name = AppStrings.DisplayNames.ProductCode)]
        public int ProductCode { get; set; }

        [Required(ErrorMessage = AppStrings.ErrorMessages.Required)]      
        public decimal Price { get; set; }
    }
}