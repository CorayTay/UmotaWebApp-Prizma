using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Core.Model
{
    public class SiparisOnay : BaseEntity
    {
        #region Alanlar

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
        public string? deluser { get; set; }
        public DateTime? deldate { get; set; }

        #endregion

        public SiparisOnay() { }
    }
}
