namespace Application.DTOs.City
{
    public class CreateCityDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        virtual public DateTime UpdatedDate { get; set; }
        virtual public bool Status { get; set; }
        public string CityName { get; set; }
    }
}
