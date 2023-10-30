using BusinessLogicLayer.Models.HotelServicesModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationsRules.FluentValidations;

public class HotelServicesValidator : AbstractValidator<HotelServicesModel>
{
    public HotelServicesValidator()
    {
        RuleFor(x => x.HotelServicesName)
            .NotEmpty()
            .NotNull()
            .WithMessage("Hotel Service Name can't be empity");
    }
}
