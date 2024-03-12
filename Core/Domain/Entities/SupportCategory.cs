using Domain.Entities.Common;

namespace Domain.Entities
{
    public class SupportCategory:BaseEntity
    {
        public string SupportCategoryName { get; set; }
        public string SupportCategoryDescription { get; set;}
    }
}
