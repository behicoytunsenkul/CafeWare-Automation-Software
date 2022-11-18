using CafeAutomation.Entities.Interrfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class OdemeHareketleri:IEntity
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; }
        public string OdemeTuru { get; set; }
        public decimal Odenen { get; set; }
        public string Aciklana { get; set; }    
        public DateTime Tarih { get; set; }
    }
}
