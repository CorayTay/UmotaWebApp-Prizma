using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaWebApp.Shared
{
    public class V042_SiparisOnay
    {
        public int logref { get; set; }
        public int SiparisRef { get; set; }
        public int OnayTipRef { get; set; }
        public int OnayRef { get; set; }
        public int OnaySira { get; set; }
        public string OnayUser { get; set; }
        public string OnayUserAdi { get; set; }
        public string Onaylayan { get; set; }
        public string Aciklama { get; set; }
        public bool? TopluOnay { get; set; }
        public byte Active { get; set; }
        public byte status { get; set; }
        public string? insuser { get; set; }
        public DateTime? insdate { get; set; }
        public string? upduser { get; set; }
        public DateTime? upddate { get; set; }
        public string? deluser { get; set; }
        public DateTime? deldate { get; set; }
        public int OnayTipIKodu { get; set; }
        public string OnayTipAdi { get; set; }
        public int OnayIKodu { get; set; }
        public string OnayAdi { get; set; }

    }
}
