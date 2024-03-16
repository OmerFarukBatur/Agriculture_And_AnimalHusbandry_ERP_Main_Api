using Application.Abstractions.Services;
using Application.Features.Commands.City.CreateCity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Main_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        readonly IMediator _mediator;
        readonly IAddressService _addressService;

        public CityController(IMediator mediator, IAddressService addressService)
        {
            _mediator = mediator;
            _addressService = addressService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCity(CreateCityCommandRequest createCityCommandRequest)
        {
            CreateCityCommandResponse commandResponse = await _mediator.Send(createCityCommandRequest);
            return Ok(commandResponse);
        }
    }
}
