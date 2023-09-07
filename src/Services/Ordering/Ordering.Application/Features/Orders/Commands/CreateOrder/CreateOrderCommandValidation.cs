using FluentValidation;

namespace Ordering.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandValidation:AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidation()
        {
            RuleFor(c => c.UserName).NotEmpty().WithMessage("Please enter User name")
                .NotNull()
                .EmailAddress().WithMessage("Username should be valid email.");
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Please enter first name")
                .MaximumLength(100).WithMessage("First name must not exceed 100 characters.");
            RuleFor(c => c.TotalPrice).GreaterThan(0).WithMessage("Total price should be greater than zero.");     
            RuleFor(c => c.EmailAddress).EmailAddress().WithMessage("Emailaddress should be valid email.");
        }
    }
}
