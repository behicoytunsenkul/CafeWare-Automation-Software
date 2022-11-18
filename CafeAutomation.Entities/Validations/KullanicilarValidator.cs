using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class KullanicilarValidator : AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad Soyad boş bırakılamaz.");
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı boş bırakılamaz.");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola boş bırakılamaz.");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon boş bırakılamaz.");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email boş bırakılamaz.");
            RuleFor(p => p.AdSoyad).EmailAddress().WithMessage("Yanlış email fortamı girişi yaptınız.");




        }
    }
}
