﻿using Domain.Entities.Common;

namespace Domain.Entities
{
    public class PlantingSupport : BaseEntity
    {
        public bool ExtraSupport { get; set; } // Önerilen ekildiğinde aktif olur
        public double SupportAmount { get; set; } // Destek miktarı
        public SupportCategory SupportCategory { get; set; } // Destek Kategorisi (n destek yardımı - 1 destek kategorisi)
    }
}