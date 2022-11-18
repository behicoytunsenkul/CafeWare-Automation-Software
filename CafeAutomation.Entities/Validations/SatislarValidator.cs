using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class SatislarValidator:AbstractValidator<Satislar>
    {
        public SatislarValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satış Kodu boş bırakılamaz.");

        }
    }
}
