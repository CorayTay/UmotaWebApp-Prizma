using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaWebApp.Shared.ModelDto.Request
{
    public class SiparisDosyaRequestDto
    {
        public Stream FileStream { get; set; }
        public string FileName { get; set; }
        public int SiparisLogRef { get; set; }
        public string InsUser { get; set; }
        public string FileType { get; set; }
    }
}
