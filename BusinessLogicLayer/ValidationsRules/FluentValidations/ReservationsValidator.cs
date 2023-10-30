using BusinessLogicLayer.Models.ReservationsModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ValidationsRules.FluentValidations;

public class ReservationsValidator:AbstractValidator<ReservationsModel>
{
    public ReservationsValidator()
    {
        RuleFor(x => x.ReservationNumber)
            .NotEmpty()
            .NotNull()
            .WithMessage("Reservation Number can't be empity");
        RuleFor(x => x.ReservationDate)
            .NotEmpty()
            .NotNull()
            .WithMessage("Reservation Date can't be empity");
        RuleFor(x => x.CustomerID)
            .NotEmpty()
            .NotNull()
            .WithMessage("Customers can't be empity");
    }
}
