using Domain.Entities.Common;

namespace Domain.Entities
{
    public class ProductPlanted : BaseEntity
    {
        public ICollection<Product> Products { get; set; } // Ekilen ürünler
    }
}
