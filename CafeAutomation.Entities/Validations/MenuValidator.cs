using CafeAutomation.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Validations
{
    public class MenuValidator:AbstractValidator<Menu>
    {
        public MenuValidator()
        {
            RuleFor(p => p.MenuAdi).NotEmpty().WithMessage("Menu Adı boş bırakılamaz.");
            RuleFor(p => p.MenuAdi).MinimumLength(3).WithMessage("Menu Adı en az 3 karakter olmalıdır.");
            RuleFor(p => p.MenuAdi).MaximumLength(15).WithMessage("Menu Adı en fazla 15 karakter olmalıdır.");


        }




    }
}

