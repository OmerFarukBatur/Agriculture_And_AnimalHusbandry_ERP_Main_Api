using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Product Product { get; set; } // Bire çok ilişki (1 kategori - n ürün)
    }
}
