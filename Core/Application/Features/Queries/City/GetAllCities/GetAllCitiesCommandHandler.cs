using Application.Abstractions.Services;
using MediatR;

namespace Application.Features.Queries.City.GetAllCities
{
    public class GetAllCitiesCommandHandler : IRequestHandler<GetAllCitiesCommandRequest, GetAllCitiesCommandResponse>
    {
        public readonly IAddressService _addressService;

        public GetAllCitiesCommandHandler(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public async Task<GetAllCitiesCommandResponse> Handle(GetAllCitiesCommandRequest request, CancellationToken cancellationToken)
        {

            return await _addressService.GetAllCitiesAsync(request);
        }
    }
}
