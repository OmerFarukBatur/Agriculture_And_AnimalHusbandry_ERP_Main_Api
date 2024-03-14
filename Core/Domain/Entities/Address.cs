using Domain.Entities.Common;
using Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Address: BaseEntity
    {
        [ForeignKey("City")]
        public Guid CityId { get; set; }
        [ForeignKey("District")]
        public Guid DistrictId { get; set; }
        [ForeignKey("Village")]
        public Guid VillageId { get; set; }
        public string FullAddress { get; set; }

        public City City { get; set; }
        public District District { get; set; }
        public Village Village { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
        public ICollection<Land> Lands { get; set; }
    }
}
