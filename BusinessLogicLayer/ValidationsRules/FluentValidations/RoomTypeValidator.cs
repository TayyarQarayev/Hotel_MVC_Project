using BusinessLogicLayer.Models.RoomTypeModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationsRules.FluentValidations;

public class RoomTypeValidator:AbstractValidator<RoomTypeModel>
{
    public RoomTypeValidator()
    {
        RuleFor(x => x.TypeName)
            .NotEmpty()
            .NotNull()
            .WithMessage("Type Name can't be empity");
    }
}
