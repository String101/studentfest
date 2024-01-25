using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace studentfest.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Product Category")]
        public string ProductCategory { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Product Count")]
        public int ProductCount { get; set; } = 0;
        [Required]
        [Display(Name = "Product Price")]
        public double ProductPrice { get; set; }

        public bool EligibleForDelivery = false;
        [Required]
        [Display(Name = "Product Warranty")]
        public string Warranty { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Product BoxItems")]
        public string BoxItems { get; set; } = string.Empty;
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public double discount { get; set; } = 25.0;
        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public Vendor Vendor { get; set; }

        [ForeignKey("Vendor")]
        public string VendorId { get; set; }
    }
}
