using Domain.Entities.Common;

namespace Domain.Entities
{
    public class City:BaseEntity
    {
        public string CityName { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
