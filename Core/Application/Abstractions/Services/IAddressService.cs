using Application.Features.Commands.City.CreateCity;

namespace Application.Abstractions.Services
{
    public interface IAddressService
    {
        #region City
        Task<CreateCityCommandResponse> CreateCityAsync(CreateCityCommandRequest request);

        #endregion
    }
}
