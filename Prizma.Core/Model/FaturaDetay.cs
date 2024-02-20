using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Core.Model
{
    public class FaturaDetay : BaseEntity
    {
        public int? Parlogref { get; set; }
        public double? Sirano { get; set; }
        public int? Mahal1ref { get; set; }
        public int? Mahal2ref { get; set; }
        public int? Mahal3ref { get; set; }
        public int? Mahal4ref { get; set; }
        public int? Mahal5ref { get; set; }
        public int? Kaynakref { get; set; }
        public int? Aktivite1ref { get; set; }
        public int? Aktivite2ref { get; set; }
        public int? Aktivite3ref { get; set; }
        public int? Aktivite4ref { get; set; }
        public int? Aktivite5ref { get; set; }
        public double? Miktar { get; set; }
        public int? Birimref { get; set; }
        public string? Aciklama { get; set; }
        public int? Irsaliyeref { get; set; }
        public int? Irsaliyedetayref { get; set; }
        public int? Siparisref { get; set; }
        public int? Siparisdetayref { get; set; }
        public int? Talepref { get; set; }
        public int? Talepdetayref { get; set; }
        public double? Fiyat { get; set; }
        public int? Fdovizref { get; set; }
        public double? Fdovizkuru { get; set; }
        public double? Tutar { get; set; }
        public double? TutarTl { get; set; }
        public double? TutarRd { get; set; }
        public double? TutarId { get; set; }
        public double? Iskyuz { get; set; }
        public double? Isktut { get; set; }
        public double? IsktutTl { get; set; }
        public double? IsktutRd { get; set; }
        public double? IsktutId { get; set; }
        public byte? Kdvkod { get; set; }
        public double? Kdvyuz { get; set; }
        public double? Kdvtut { get; set; }
        public double? KdvtutTl { get; set; }
        public double? KdvtutRd { get; set; }
        public double? KdvtutId { get; set; }
        public double? Tutarnet { get; set; }
        public double? TutarnetTl { get; set; }
        public double? TutarnetRd { get; set; }
        public double? TutarnetId { get; set; }
        public byte? Fiyatfarki { get; set; }
        public byte? Miktarfarki { get; set; }
        public int? Malzemeref { get; set; }
        public double? Tevkifatpayda { get; set; }
        public double? Tevkifatpay { get; set; }
        public double? Miktar2katsayi { get; set; }
        public double? Miktar2 { get; set; }
        public int? Sozlesmeref { get; set; }
        public int? Sozlesmedetayref { get; set; }
        public int? Lgfatlineno { get; set; }
        public int? LgfatlinenoAna { get; set; }
        public string? Tevkifatkodu { get; set; }

        public FaturaDetay() { }
    }
}
