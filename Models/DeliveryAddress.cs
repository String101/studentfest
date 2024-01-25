using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace studentfest.Models
{
    public class DeliveryAddress
    {
        public int Id { get; set; }

        [Display(Name = "House Number")]
        [Required]
        public string HouseNumber { get; set; } = string.Empty;
        [Display(Name = "Street Name")]
        [Required]
        public string StreetName { get; set; } = string.Empty;
        [Display(Name = "Suburb Number")]
        [Required]
        public string suburb { get; set; } = string.Empty;
        [Display(Name = "City")]
        [Required]
        public string City { get; set; } = string.Empty;
        [Display(Name = "Region")]
        [Required]
        public string Region { get; set; } = string.Empty;
        [Display(Name = "Postal Code")]
        [Required]
        public string PostalCode { get; set; } = string.Empty;
        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; } = string.Empty;

        [NotMapped]
        public User User { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
