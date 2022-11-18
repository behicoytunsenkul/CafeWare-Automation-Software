using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(p => p.UrunKodu).NotEmpty().WithMessage("Ürün Kodu boş bırakılamaz.");
            RuleFor(p => p.UrunAdi).NotEmpty().WithMessage("Ürün Adı boş bırakılamaz.");
            RuleFor(p => p.BirimFiyati1).NotEmpty().WithMessage("Birim Fiyatı1 boş bırakılamaz.");
            RuleFor(p => p.BirimFiyati2).NotEmpty().WithMessage("Birim Fiyatı2 boş bırakılamaz.");
            RuleFor(p => p.BirimFiyati3).NotEmpty().WithMessage("Birim Fiyatı3 boş bırakılamaz.");

        }
    }
}
