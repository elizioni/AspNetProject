using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetProject.ViewModels
{
    public class AdProductViewModel
    {
        
            [Required]
            [MaxLength(50)]
        public string Title { get; set; }

           [Required]
           [MaxLength(200)]
          [Display(Name = "Ad Description")]
        public string AdDescription { get; set; }

        
        [Display(Name = "Ad Image")]
        public string Image { get; set; }

        [Display(Name = "Ad Date")]
        public DateTime? AdDate { get; set; }

        [Required]
        [Display(Name = "Product Publisher")]
        public string productPublisher { get; set; }

        [Required]
        [Display(Name = "Product Description")]
        public string productDescription { get; set; }

        [Required]
        [Display(Name = "Product Price")]
        public double productPrice { get; set; }

        
        [Display(Name = "Product First Image")]
        public string productFirstImage { get; set; }

        
        [Display(Name = "Product Second Image")]
        public string productSecondImage { get; set; }
    }
}