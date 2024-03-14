using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }// bire çok ilişki
        public ICollection<ProductPlanted> ProductPlanteds { get; set; }
    }
}
