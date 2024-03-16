using Application.Abstractions.Services;
using FluentValidation.Results;
using MediatR;

namespace Application.Features.Commands.City.CreateCity
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommandRequest, CreateCityCommandResponse>
    {
        public readonly IAddressService _addressService;

        public CreateCityCommandHandler(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public async Task<CreateCityCommandResponse> Handle(CreateCityCommandRequest request, CancellationToken cancellationToken)
        {
            CreateCityCommandValidator validationRules = new();
            ValidationResult result = validationRules.Validate(request);

            if (result.IsValid)
            {
                return await _addressService.CreateCityAsync(request);
            }
            return new()
            {
                Message = result.Errors[0].ErrorMessage,
                Status = false
            };
        }
    }
}
