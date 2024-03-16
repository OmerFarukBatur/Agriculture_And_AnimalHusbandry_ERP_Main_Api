using MediatR;

namespace Application.Features.Commands.City.CreateCity
{
    public class CreateCityCommandRequest:IRequest<CreateCityCommandResponse>
    {
        public string CityName { get; set; }
    }
}