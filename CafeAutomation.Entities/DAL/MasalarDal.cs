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
    public class MasalarDal: EntityRepositoryBase<CafeContext, Masalar,MasalarValidator>
    {
        public Object MasaListeleme(CafeContext context)
        {
            var model = (from masa in context.Masalar
                         join k in context.Kullacilar on masa.KullaniciId equals k.Id into kullanici from kullanicimasa in kullanici.DefaultIfEmpty()//MASALAR ILE KULLANICILAR 'JOIN' ILE BIRLESTIRDIM
                         select new
                         {
                             masa.Aciklama,
                             masa.Durumu,
                             masa.EklenmeTarihi,
                             masa.Id,
                             masa.Islem,
                             masa.MasaAdi,
                             masa.RezerveMi,
                             masa.SonIslemTarihi,
                             Kullanici = kullanicimasa.KullaniciAdi //KULLANICI ID, AD-SOYAD SEKLINDE GOZUKECEK
                         }).ToList();
            return model;
        }
    }
}
