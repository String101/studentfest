using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studentfest.Models
{
    public class Vendor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ValidateNever]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string VendorTitle { get; set; } = string.Empty;
        [Required]
        [MinLength(2, ErrorMessage = "Your \"First Name\" must atleast be 2 charactors long or more")]
        [Display(Name = "First Name")]
        public string VendorFirstName { get; set; } = string.Empty;
        [Required]

        [MinLength(2, ErrorMessage = "Your \"Last Name\" must atleast be 2 charactors long or more")]
        [Display(Name = "Last Name")]
        public string VendorLastName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string VendorEmailAddresss { get; set; } = string.Empty;

        [Required]
        [MinLength(13, ErrorMessage = "Invalid ID Number")]
        [Display(Name = "ID Number")]
        public string VendorIdNumber { get; set; }
       
        public ICollection<Product>? Products { get; set; }

        public bool ApprovedVendor { get; set; } = false;
        [ForeignKey("ContactDetails")]
        public string? ContactDetailsId { get; set; }
        [ValidateNever]
        [NotMapped]
        public ContactDetails ContactDetails { get; set; }

        [ForeignKey("ResidentalAddress")]
        public string? ResidentalAddressId { get; set; }
        [ValidateNever]
        [NotMapped]
        public ResidentalAddress ResidentalAddress { get; set; }
   
    }
}
