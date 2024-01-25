using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace studentfest.Models
{
    public class User: IdentityUser
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Surname { get; set; }

        public string PhoneNumber { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string Image_url { get; set; }

        public DateTime LastLogin { get; set; }= DateTime.Now;

        public bool islogged { get; set; } = false;
        public DeliveryAddress? DeliveryAddress { get; set; }
        public string Role { get; set; }

       
    }
}
