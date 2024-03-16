using FluentValidation;

namespace Application.Features.Commands.City.CreateCity
{
    public class CreateCityCommandValidator : AbstractValidator<CreateCityCommandRequest>
    {
        public CreateCityCommandValidator()
        {
            RuleFor(x => x.CityName)
                .NotNull()
                .NotEmpty()
                .WithMessage("Lütfen Başlık alanını boş geçmeyiniz.")
                .MaximumLength(250)
                .MinimumLength(5)
                .WithMessage("Lütfen girilen Başlık degeri enaz 2 ve encok 250 karakter olacak şekilde giriniz.");
        }
    }
}
