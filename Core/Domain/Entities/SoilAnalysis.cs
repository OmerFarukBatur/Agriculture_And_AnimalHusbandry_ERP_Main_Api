using Domain.Entities.Common;

namespace Domain.Entities
{
    public class SoilAnalysis :BaseEntity
    {
        public DateTime AnalysisDate { get; set; } // Analiz tarihi
        public double pH { get; set; }
        public string SoilType { get; set; }// Bünye örn Tınlı Killi-tın
        public double SaltContent { get; set; } // tuz oranı
        public double LimeRatio { get; set; } //CaCO3 kireç oranı
        public double PhosphorusRate { get; set; } // Fosfor oranı
        public double PotassiumRatio { get; set; }// Potasyum Oranı
        public double CalciumRatio { get; set; } // Kalsiyum oranı
        public double MagnesiumRatio { get; set; } // Magnezyum Oranı
        public double OrganicMatterRate { get; set; }// Organik madde oranı
        public double InorganicNitrogenRatio { get; set; } // İnorganik azot miktarı
        public double SodiumRatio { get; set; } // Sodyum oranı
        public double BoronRate { get; set; } // Bor oranı
        public double CopperRate { get; set; } // Bakır oranı
        public double IronRate { get; set; } // Demir oranı
        public double ZincRatio { get; set; } // Çinko oranı
        public double ManganeseRatio { get; set; } // Mangan oranı
        public string AnalysisDescription { get; set; } // Analiz açıklaması/sonucu

        public Guid LandId { get; set; }
        public Guid UnitOfMeasurementId { get; set; }

        public UnitOfMeasurement UnitOfMeasurement { get; set; } // Analiz oranlarının birimleri -- bire bir ilişki

        public Land Land { get; set; }
    }
}
