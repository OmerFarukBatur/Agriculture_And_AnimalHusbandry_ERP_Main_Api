using Domain.Entities.Common;
using Domain.Entities.Identity;

namespace Domain.Entities
{
    public class Address: BaseEntity
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Village { get; set; }
        public string FullAddress { get; set; }

        public ICollection<AppUser> AppUsers { get; set; }
        public ICollection<Land> Lands { get; set; }
    }
}
