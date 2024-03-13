using Domain.Entities.Common;
using Domain.Entities.Identity;

namespace Domain.Entities
{
    public class Land :BaseEntity
    {
        public string LandName { get; set; }
        public string LandDescription { get; set;}
        public int IslandNo { get; set; }
        public int Parcel { get; set; }
        public int Area { get; set; }
        public string Location { get; set; }
        public bool WasItPlanted { get; set; } // Ekilip Ekilmediğini belli eder

        public Guid UserId { get; set; }
        public Guid IcarUserId { get; set; }
        public Guid UnitOfMeasurementId { get; set; }
        public Guid AddressId { get; set; }


        public AppUser User { get; set; } // Bir e çok ilişki
        public AppUser IcarUser { get; set; } // İcarlayan kişi  Bir e çok ilişki
        public UnitOfMeasurement UnitOfMeasurement { get; set; } // Bir e çok ilişki
        public Address Address { get; set; } // Birebir ilişki
        public ICollection<SoilAnalysis> SoilAnalysis { get; set; } // Bire çok ilişki (1 toprak - n analiz)
        public ICollection<ProductPlanted> ProductPlanteds { get; set; } // Ekilen ürünler(1 tarla - n ürün)
        public ICollection<ProductRecommended> ProductRecommendeds { get; set; } // Önerilen ürünler(1 tarla - n ürün)
        public ICollection<PlantingSupport> PlantingSupports { get; set; } // Destek Tipi (1 toprak - n destek)
    }
}
