using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using System.Text;
using System.Threading;
using CoreData.Models;

namespace StandardLibrary.Validator
{
    public class HelloValidator : AbstractValidator<Hello>
    {
        public HelloValidator()
        {
            RuleSet("notEmpty", () =>
            {
                RuleFor(hello => hello.HelloText).NotEmpty().WithMessage("{PropertName} darf nicht leer sein");
            });

            RuleSet("isEmpty", () =>
            {
                RuleFor(hello => hello.HelloText).Empty().WithMessage("{PropertName} muss leer sein");
            });
        }
    }
}
