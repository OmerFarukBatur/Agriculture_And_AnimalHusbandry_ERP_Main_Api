using Domain.Entities.Common;

namespace Domain.Entities
{
    public class ProductPlanted : BaseEntity
    {

        public List<Land> Lands { get; set; }
        public ICollection<Product> Products { get; set; } // Ekilen ürünler
    }
}
