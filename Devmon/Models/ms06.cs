using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devmon.Models
{
    public class ms06
    {
        public int id { get; set; }
        public string lokasi { get; set; }
        public DateTime waktu { get; set; }
        public string controller { get; set; }
        public string mac { get; set; }
        public string ip { get; set; }
        public decimal voltage_ac { get; set; }
        public decimal voltage_ac_2 { get; set; }
        public decimal voltage_dc { get; set; }
        public decimal voltage_dc_2 { get; set; }
        public decimal ampere_ac { get; set; }
        public decimal ampere_ac_2 { get; set; }
        public decimal ampere_dc { get; set; }
        public decimal ampere_dc_2 { get; set; }


    }
}
