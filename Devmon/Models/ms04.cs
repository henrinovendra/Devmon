using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devmon.Models
{
    public class ms04
    {
        public int id { get; set; }
        public string lokasi { get; set; }
        public DateTime waktu { get; set; }
        public string controller { get; set; }
        public string mac { get; set; }
        public string ip { get; set; }
        public decimal sensorsuhu_in { get; set; }
        public decimal sensorsuhu_out { get; set; }
        public decimal voltage_ac { get; set; }
        public decimal voltage_dc { get; set; }
        public decimal ampere_ac { get; set; }
        public decimal ampere_dc { get; set; }

    }
}
