using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicM.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "Date")]
        public DateTime ReleasedDate  { get; set; }

        public string Description { get; set; }
        public string Company { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        [Range(1,10000)]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 1-5")]
        public double Price { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 6-10")]
        public double Price5 { get; set; }
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 10+")]
        public double Price10 { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }//if same name without id with same prop name of class
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; } //EFC will make it foreign key
        [Required]
        [Display(Name = "Cover Type")]
        public int CoverTypeId { get; set; }
        [ValidateNever]
        public CoverType CoverType { get; set; }

    }
}
