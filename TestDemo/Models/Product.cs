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

        [Required(ErrorMessage = AppStrings.ErrorRequired)]
        public string Name { get; set; }

        [Required(ErrorMessage = AppStrings.ErrorRequired)]
        [Display(Name = AppStrings.DisplayNameManufacturer)]
        public int ManufacturerId { get; set; }

        [Required(ErrorMessage = AppStrings.ErrorRequired)]
        [Display(Name = AppStrings.DisplayNameProductCode)]
        public int ProductCode { get; set; }

        [Required(ErrorMessage = AppStrings.ErrorRequired)]      
        public decimal Price { get; set; }
    }
}