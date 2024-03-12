using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Address: BaseEntity
    {
        public string City { get; set; }
        public string District { get; set; }
        public string Village { get; set; }
        public string FullAddress { get; set; }
    }
}
