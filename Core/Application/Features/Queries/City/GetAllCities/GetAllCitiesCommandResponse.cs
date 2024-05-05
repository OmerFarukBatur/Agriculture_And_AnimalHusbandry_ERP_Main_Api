using Application.DTOs.City;

namespace Application.Features.Queries.City.GetAllCities
{
    public class GetAllCitiesCommandResponse
    {
        public List<GetAllCitiesDto> GetAllCities { get; set; }
    }
}