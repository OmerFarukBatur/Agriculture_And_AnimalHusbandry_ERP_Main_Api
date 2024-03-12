using Domain.Entities.Common;

namespace Domain.Entities
{
    public class UnitOfMeasurement: BaseEntity
    {
        public string UnitName { get; set; }
        public string Description { get; set; }

        public Land Land { get; set; } // Tarlanın bir ölçü birimi olur, ölçü biriminin birden fazla tarlası
    }
}
