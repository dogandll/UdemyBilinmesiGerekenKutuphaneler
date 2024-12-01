using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş olamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş olamaz").EmailAddress().WithMessage("Email alanı doğru formatta girilmelidir.");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Age alanı boş olamaz").InclusiveBetween(18, 60).WithMessage("Yaş aralığı 18 - 60 arası olmalıdır !");
        }
    }
}
