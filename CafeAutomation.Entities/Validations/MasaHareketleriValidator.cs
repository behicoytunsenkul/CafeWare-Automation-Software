using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class MasaHareketleriValidator:AbstractValidator<MasaHareketleri>
    {

        public MasaHareketleriValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satış Kodu boş bırakılamaz.");
            RuleFor(p => p.SatisKodu).Length(12).NotEmpty().WithMessage("Satis Kodu 12 Karakteri Gecemez.");
            RuleFor(p => p.Miktari).NotEmpty().WithMessage("Miktar boş bırakılamaz.");
            RuleFor(p => p.Miktari).GreaterThan(0).WithMessage("Miktar boş bırakılamaz.");
            RuleFor(p => p.BirimFiyati).NotEmpty().WithMessage("Birim Fiyatı boş bırakılamaz.");
            RuleFor(p => p.BirimFiyati).LessThanOrEqualTo(100000).WithMessage("Birim fiyatı en çok 100000.");

        }
    }
}
