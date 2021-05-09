using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.Amount).NotEmpty().InclusiveBetween(1,10);
            RuleFor(p => p.Email).NotEmpty().When(p => p.PhoneNumber == null);
            RuleFor(p => p.PhoneNumber).NotEmpty().When(p => p.Email == null);
            RuleFor(p => p.CustomPrintPhoto).MaximumLength(2048);
            RuleFor(p => p.Address).NotEmpty();
         
        }
    }
}
