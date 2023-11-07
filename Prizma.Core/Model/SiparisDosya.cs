using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Core.Model
{
    public class SiparisDosya : BaseEntity
    {
        public int SiparisLogRef { get; private set; }
        public string DosyaAdi { get; private set; }
        public string DosyaTipi { get; private set; }

        private SiparisDosya()
        {

        }

        public static SiparisDosya Create(string adi, string tipi, int siparisLogRef, string insuser)
        {
            var td = new SiparisDosya();
            td.insdate = DateTime.Now;
            td.insuser = insuser;
            td.DosyaAdi = adi;
            td.DosyaTipi = tipi;
            td.SiparisLogRef = siparisLogRef;

            return td;
        }
    }
}
