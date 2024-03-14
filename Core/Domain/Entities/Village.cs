using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Village :BaseEntity
    {
        public string VillageName { get; set; }
        [ForeignKey("District")]
        public Guid DistrictId { get; set; }
        public District District { get; set; }
    }
}
