using FluentValidation;
using InventoryApi.DTOs;

namespace InventoryApi.Validations
{
    public class ProductValidator : AbstractValidator<ProductCreateDto>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required.");

            RuleFor(x => x.Quantity)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Quantity must be greater or equal to 0.");
        }
    }
}
