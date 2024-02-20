using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaWebApp.Shared
{
    public class V048_FaturaDetay
    {
        public int Logref { get; set; }
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
        public byte? Status { get; set; }
        public string? Insuser { get; set; }
        public DateTime? Insdate { get; set; }
        public string? Upduser { get; set; }
        public DateTime? Upddate { get; set; }
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
        public string? Mahal1kodu { get; set; }
        public string? Mahal1adi { get; set; }
        public string? Mahal2kodu { get; set; }
        public string? Mahal2adi { get; set; }
        public string? Mahal3kodu { get; set; }
        public string? Mahal3adi { get; set; }
        public string? Mahal4kodu { get; set; }
        public string? Mahal4adi { get; set; }
        public string? Mahal5kodu { get; set; }
        public string? Mahal5adi { get; set; }
        public string? Kaynakkodu { get; set; }
        public string? Kaynakadi { get; set; }
        public string? Aktivite1kodu { get; set; }
        public string? Aktivite1adi { get; set; }
        public string? Aktivite2kodu { get; set; }
        public string? Aktivite2adi { get; set; }
        public string? Aktivite3kodu { get; set; }
        public string? Aktivite3adi { get; set; }
        public string? Aktivite4kodu { get; set; }
        public string? Aktivite4adi { get; set; }
        public string? Aktivite5kodu { get; set; }
        public string? Aktivite5adi { get; set; }
        public string? Birimkodu { get; set; }
        public string? Birimadi { get; set; }
        public string? Fdovizkodu { get; set; }
        public string? Fdovizadi { get; set; }
        public string? Talepfisno { get; set; }
        public DateTime? Talepfistarih { get; set; }
        public double? Talepdetaysirano { get; set; }
        public string? Siparisno { get; set; }
        public DateTime? Siparistarih { get; set; }
        public double? Siparisdetaysirano { get; set; }
        public int? Siparisdetaybirimref { get; set; }
        public string? Irsaliyeno { get; set; }
        public DateTime? Irsaliyetarih { get; set; }
        public double? Irsaliyedetaysirano { get; set; }
        public double? Irsaliyemiktar { get; set; }
        public string? Malzemekodu { get; set; }
        public string? Malzemeadi { get; set; }
        public string? Sozlesmeno { get; set; }
        public DateTime? Sozlesmeimzatarih { get; set; }
        public double? Sozlesmedetaysirano { get; set; }

        public string TutarFormatted
        {
            get
            {
                return this.Tutar.HasValue ? String.Format("{0:N2}", this.Tutar.Value) : "";
            }
        }
        public string TutarIdFormatted
        {
            get
            {
                return this.TutarId.HasValue ? String.Format("{0:N2}", this.TutarId.Value) : "";
            }
        }
        public string IsktutFormatted
        {
            get
            {
                return this.Isktut.HasValue ? String.Format("{0:N2}", this.Isktut.Value) : "";
            }
        }
        public string IsktutIdFormatted
        {
            get
            {
                return this.IsktutId.HasValue ? String.Format("{0:N2}", this.IsktutId.Value) : "";
            }
        }
        public string KdvtutFormatted
        {
            get
            {
                return this.Kdvtut.HasValue ? String.Format("{0:N2}", this.Kdvtut.Value) : "";
            }
        }
        public string KdvtutIdFormatted
        {
            get
            {
                return this.KdvtutId.HasValue ? String.Format("{0:N2}", this.KdvtutId.Value) : "";
            }
        }
        public string TutarnetFormatted
        {
            get
            {
                return this.Tutarnet.HasValue ? String.Format("{0:N2}", this.Tutarnet.Value) : "";
            }
        }
        public string TutarnetIdFormatted
        {
            get
            {
                return this.TutarnetId.HasValue ? String.Format("{0:N2}", this.TutarnetId.Value) : "";
            }
        }
    }
}
