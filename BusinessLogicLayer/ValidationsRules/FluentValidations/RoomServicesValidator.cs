using BusinessLogicLayer.Models.RoomServicesModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationsRules.FluentValidations;

public class RoomServicesValidator : AbstractValidator<RoomServicesModel>
{
    public RoomServicesValidator()
    {
        RuleFor(x => x.RoomServicesName)
            .NotEmpty()
            .NotNull()
            .WithMessage("Room Service Name can't be empity");
    }
}
