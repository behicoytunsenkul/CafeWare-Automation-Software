using CafeAutomation.Entities.Interrfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAutomation.Entities.Models
{
    public class Roller:IEntity
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public string ControlCaption { get; set; }


    }
}
