using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace studentfest.Models
{
    public class ContactDetails
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string? Id { get; set; }

        [Display(Name = "Country Code")]
        public string CountryCode { get; set; } = string.Empty;
        [Display(Name = "Mobile Number")]
        public int MobileNumber { get; set; }
        [Display(Name = "Other Mobile Number")]
        public int AlternativeNumber { get; set; }
        [Display(Name = "Other Email Address")]
        public string AlternativeEmailAddress { get; set; } = string.Empty;

        [ForeignKey("Vendor")]
        public string? VendorId { get; set; }
        [ValidateNever]
        public Vendor Vendor { get; set; }


       
  
    }
}
