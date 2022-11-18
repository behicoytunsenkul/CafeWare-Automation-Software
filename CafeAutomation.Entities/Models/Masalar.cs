﻿using CafeAutomation.Entities.Interrfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class Masalar:IEntity
    {
        public int Id { get; set; }
        public string MasaAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Durumu { get; set; }
        public bool RezerveMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime SonIslemTarihi { get; set; }
        public string Islem { get; set; }
        public int? KullaniciId { get; set; }
        public ICollection<MasaHareketleri> MasaHareketleri { get; set; }


    }
}
