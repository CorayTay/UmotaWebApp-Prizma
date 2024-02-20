using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Core.Model
{
    public class FaturaOnay : BaseEntity
    {
        public int? Onaytipref { get; set; }
        public int? Onayref { get; set; }
        public string? Aciklama { get; set; }
        public int? Faturaref { get; set; }
        public string? Onayuser { get; set; }
        public string? Onaymail { get; set; }
        public int? Onaysira { get; set; }
        public byte? Active { get; set; }
        public string? Onaylayan { get; set; }
        public bool? Topluonay { get; set; }
        public string? Onayuseradi { get; set; }
        public string? Deluser { get; set; }
        public DateTime? Deldate { get; set; }

        public FaturaOnay() { }
    }
}
