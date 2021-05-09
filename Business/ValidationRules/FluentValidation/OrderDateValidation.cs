using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderDateValidation:AbstractValidator<Order>
    {
        public OrderDateValidation()
        {
            RuleFor(p => p.DeliveryDate).NotEmpty().GreaterThan(p => p.PreparationDate);
            RuleFor(p => p.PreparationDate).GreaterThan(p => p.CreatedAt);
        }
    }
}
