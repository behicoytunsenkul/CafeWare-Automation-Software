using CafeAutomation.Entities.Models;
using CafeAutomation.Entities.Repository;
using CafeAutomation.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.DAL
{
    public class UrunDal: EntityRepositoryBase<CafeContext, Urun,UrunValidator>
    {
        public object UrunListele(CafeContext context)//Urun katologunda menü adı gözükmesi icin yeni bir fonk yarattım
        {
            var liste = (from urun in context.Urun
                         select new
                         {
                             urun.Id,
                             urun.MenuId,
                             Menu=urun.Menu.MenuAdi,
                             urun.UrunKodu,
                             urun.UrunAdi,
                             urun.BirimFiyati1,
                             urun.BirimFiyati2,
                             urun.BirimFiyati3,
                             urun.Aciklama,
                             urun.Resim,
                             urun.Tarih
                         }).ToList();
            return liste;
        }
    }
}
