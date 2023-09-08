using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandValidator:AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(c => c.Id).GreaterThan(0).WithMessage("Please enter order id");
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
