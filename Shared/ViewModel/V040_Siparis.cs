using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaWebApp.Shared
{
    public class V040_Siparis
    {
        public int LogRef { get; set; }
        public string FisNo { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Saat { get; set; }
        public int? ProjeRef { get; set; }
        public int? CariRef { get; set; }
        public int? DurumRef { get; set; }
        public byte? Status { get; set; }
        public string? InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string? UpdUser { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte? DosyaEki { get; set; }
        public int? lgFirmaNo { get; set; }
        public int? DovizRefRD { get; set; }
        public double? DovizkuruRD { get; set; }
        public int? DovizRefID { get; set; }
        public byte DovizKurTurID { get; set; }
        public double? DovizKuruID { get; set; }
        public double? NetToplamID { get; set; }
        public double? NetToplamTL { get; set; }
        public double? NetToplamRD { get; set; }
        public byte Iptal { get; set; }
        public string? IptalUser { get; set; }
        public DateTime? IptalDate { get; set; }
        public string? IptalNedeni { get; set; }

        public int? DurumiKodu { get; set; }
        public string? DurumAdi { get; set; }
        public int? Renk1 { get; set; }
        public int? Renk2 { get; set; }
        public string? ProjeKodu { get; set; }
        public string? ProjeAdi { get; set; }
        public int? ProjeSirketRef { get; set; }
        public string? ProjeSirketKodu { get; set; }
        public string? ProjeSirketAdi { get; set; }
        public string? CariKodu { get; set; }
        public string? CariAdi { get; set; }
        public string? DovizKoduRD { get; set; }
        public string? DovizKoduID { get; set; }
        public string TarihFormatted
        {
            get
            {
                return this.Tarih.HasValue ? this.Tarih.Value.ToString("dd.MM.yyyy") : "-";
            }
        }
        public string NetToplamTLFormatted
        {
            get
            {
                return this.NetToplamTL.HasValue ? String.Format("{0:N2}", this.NetToplamTL.Value) : "";
            }
        }
        public string NetToplamIDFormatted
        {
            get
            {
                return this.NetToplamID.HasValue ? String.Format("{0:N2}", this.NetToplamID.Value) : "";
            }
        }

    }
}
