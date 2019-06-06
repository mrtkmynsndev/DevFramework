using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using DevFramework.Entities.Concrete;

namespace DevFramework.Business.ValidationRules.FluentValidation
{
    public class ProductValidator  : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.CategoryId).NotEmpty();
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.UnitPrice).GreaterThan(0.0m);
            RuleFor(x => x.QuantityPerUnit).NotEmpty();
            //RuleFor(x => x.ProductName).Must(StartWith);
        }

        private bool StartWith(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
