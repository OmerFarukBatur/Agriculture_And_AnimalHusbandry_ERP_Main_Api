using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string NameSurname { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }

        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        //public ICollection<Address> Addresses { get; set; }
        //public ICollection<Land> Lands { get; set; }
    }
}
