using Domain.Entities.Common;

namespace Domain.Entities
{
    public class ProductRecommended : BaseEntity
    {
        public ICollection<Product> Products { get; set; } // Önerilen ürünler
    }
}
