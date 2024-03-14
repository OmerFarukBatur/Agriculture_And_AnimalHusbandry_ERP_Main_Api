using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class District:BaseEntity
    {
        public string DistrictName { get; set; }
        [ForeignKey("City")]
        public Guid CityId { get; set; }
        public City City { get; set; }
        public ICollection<Village> Villages { get; set; }
    }
}
