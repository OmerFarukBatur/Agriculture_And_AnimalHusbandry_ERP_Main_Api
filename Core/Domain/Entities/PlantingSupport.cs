using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PlantingSupport : BaseEntity
    {
        public bool ExtraSupport { get; set; } // Önerilen ekildiğinde aktif olur
        public double SupportAmount { get; set; } // Destek miktarı


        [ForeignKey("Land")]
        public Guid LandId { get; set; }
        [ForeignKey("SupportCategory")]
        public Guid SupportCategoryId { get; set; }

        public Land Land { get; set; }
        public SupportCategory SupportCategory { get; set; } // Destek Kategorisi (n destek yardımı - 1 destek kategorisi)
    }
}
