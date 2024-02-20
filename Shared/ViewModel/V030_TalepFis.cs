using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaWebApp.Shared
{
    public class V030_TalepFis
    {
        public int LogRef { get; set; }
        public string FisNo { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Saat { get; set; }
        public int? TurRef { get; set; }
        public int? ProjeRef { get; set; }
        public string? TalepEden { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public int? TeslimYeriRef { get; set; }
        public int? DurumRef { get; set; }
        public byte? Status { get; set; }
        public string? InsUser { get; set; }
        public DateTime? InsDate { get; set; }
        public string? UpdUser { get; set; }
        public DateTime? UpdDate { get; set; }
        public byte? DosyaEki { get; set; }
        public byte? Oncelik { get; set; }
        public string? Aciklama { get; set; }
        public int? FirmaNo { get; set; }

        public int? DurumiKodu { get; set; }
        public string? DurumAdi { get; set; }
        public int? Renk1 { get; set; }
        public int? Renk2 { get; set; }

        public int? TuriKodu { get; set; }
        public string? TurAdi { get; set; }
        public string? TurKodu { get; set; }

        public int? TeslimYeriiKodu { get; set; }
        public string? TeslimYeriAdi { get; set; }
        public string? TeslimYeriKodu { get; set; }


        public string? ProjeKodu { get; set; }
        public string? ProjeAdi { get; set; }
        public int? ProjeSirketRef { get; set; }
        public string? ProjeSirketKodu { get; set; }
        public string? ProjeSirketAdi { get; set; }

        public string TarihFormatted
        {
            get
            {
                return this.Tarih.HasValue ? this.Tarih.Value.ToString("dd.MM.yyyy") : "-";
            }
        }

        public string TeslimTarihiFormatted
        {
            get
            {
                return this.TeslimTarihi.HasValue ? this.TeslimTarihi.Value.ToString("dd.MM.yyyy") : "-";
            }
        }
    }
}
