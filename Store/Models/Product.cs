using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description {  get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        [Display(Name = "Price for 1 product")]
        [Range(1, 10000)]
        public double Price {  get; set; }
        [Required]
        [Display(Name = "Price for 2-5 products")]
        [Range(1, 10000)]
        public double Price2 { get; set; }
        [Required]
        [Display(Name = "Price for 6+ products")]
        [Range(1, 10000)]
        public double Price3 { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl {  get; set; }
    }
}
