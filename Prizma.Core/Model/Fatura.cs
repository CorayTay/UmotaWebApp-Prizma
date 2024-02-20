using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Core.Model
{
    public class Fatura : BaseEntity
    {
        public int? Fistip { get; set; }
        public string Fisno { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? Saat { get; set; }
        public string? Belgeno { get; set; }
        public int? Cariref { get; set; }
        public int? Projeref { get; set; }
        public int? Ambarno { get; set; }
        public string? Ambaradi { get; set; }
        public int? DovizrefRd { get; set; }
        public double? DovizkuruRd { get; set; }
        public double? NettoplamRd { get; set; }
        public int? DovizrefId { get; set; }
        public double? DovizkuruId { get; set; }
        public double? NettoplamId { get; set; }
        public double? NettoplamTl { get; set; }
        public byte? DovizkurturId { get; set; }
        public int? Lgfatref { get; set; }
        public string? Lgfatno { get; set; }
        public byte? Efatura { get; set; }
        public byte? Fiyatfarki { get; set; }
        public byte? Miktarfarki { get; set; }
        public int? Lgfirmano { get; set; }
        public int? Durumref { get; set; }
        public bool? Lgaktarildi { get; set; }
        public string? Aciklama { get; set; }
        public string? Aciklama2 { get; set; }
        public byte? Dosyaeki { get; set; }
        public string? Seri { get; set; }
        public bool? PlanlamaKontrol { get; set; }
        public double? NettoplamSozlesmeId { get; set; }
        public double? NettoplamSozlesmeTl { get; set; }
        public double? NettoplamSiparisId { get; set; }
        public double? NettoplamSiparisTl { get; set; }
        public double? NettoplamDigerId { get; set; }
        public double? NettoplamDigerTl { get; set; }
        public int? LgfatrefFf { get; set; }
        public string? LgfatnoFf { get; set; }
        public int? LgfatrefMf { get; set; }
        public string? LgfatnoMf { get; set; }
        public int? LgfatrefAna { get; set; }
        public string? LgfatnoAna { get; set; }
        public int? FiyatFarkiTipi { get; set; }
        public int? Anafatref { get; set; }
        public int? Vadegun { get; set; }
        public bool? Lgaktarilmasin { get; set; }
        public bool? KasadanOdendi { get; set; }
        public string? Odemeplankodu { get; set; }

        public Fatura() { }
    }
}
