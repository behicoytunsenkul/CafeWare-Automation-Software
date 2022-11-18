﻿using CafeAutomation.Entities.Interrfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class Kullanicilar:IEntity
    {
        public int Id { get; set; } 
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Gorevi { get; set; }  
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public string Aciklama { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool AktifMi { get; set; }
        public ICollection<KullaniciHareketleri> KullaniciHareketleri { get; set; }
    }
}
