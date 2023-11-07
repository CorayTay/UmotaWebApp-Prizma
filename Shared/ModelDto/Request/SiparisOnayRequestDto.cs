using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaWebApp.Shared.ModelDto.Request
{
    public class SiparisOnayRequestDto
    {
        public short FirmaId { get; set; }
        public string kullanicikodu { get; set; }
        public int SiparisRef { get; set; }
        public int OnayLineRef { get; set; }
        public int OnayDurumu { get; set; }
        public string Aciklama { get; set; }
    }
}
