using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }// bire çok ilişki
        public ICollection<ProductPlanted> ProductPlanteds { get; set; }
    }
}
