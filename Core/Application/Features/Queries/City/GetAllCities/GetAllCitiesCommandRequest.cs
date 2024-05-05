using MediatR;

namespace Application.Features.Queries.City.GetAllCities
{
    public class GetAllCitiesCommandRequest:IRequest<GetAllCitiesCommandResponse>
    {
    }
}