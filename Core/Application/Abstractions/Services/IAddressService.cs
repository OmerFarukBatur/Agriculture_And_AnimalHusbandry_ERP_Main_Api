using Application.Features.Commands.City.CreateCity;
using Application.Features.Queries.City.GetAllCities;

namespace Application.Abstractions.Services
{
    public interface IAddressService
    {
        #region City
        Task<CreateCityCommandResponse> CreateCityAsync(CreateCityCommandRequest request);
        Task<GetAllCitiesCommandResponse> GetAllCitiesAsync(GetAllCitiesCommandRequest request);

        #endregion
    }
}
