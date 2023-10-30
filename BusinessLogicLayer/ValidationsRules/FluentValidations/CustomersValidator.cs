using BusinessLogicLayer.Models.CustomersModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationsRules.FluentValidations;

public class CustomersValidator:AbstractValidator<CustomersModel>
{
    public CustomersValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .NotNull()
            .WithMessage("First Name can't be empity");
        RuleFor(x => x.LastName)
            .NotEmpty()
            .NotNull()
            .WithMessage("Last Name can't be empity");
        RuleFor(x => x.DateOfBirth)
            .NotEmpty()
            .NotNull()
            .WithMessage("Date of Birth can't be empity");
        RuleFor(x => x.ContactNO)
            .NotEmpty()
            .NotNull()
            .WithMessage("Contact number can't be empity");
    }
}
