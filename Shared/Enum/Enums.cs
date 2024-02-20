using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaWebApp.Shared.Enum
{
    public class SharedEnums
    {
        public enum TeklifPdfType
        {
            Iskontolu = 0,
            Net = 1,
            NetKdv = 2
        }

        public enum TalepFisDurum
        {
            Oneri = 180,
            OnaySurecinde = 181,
            Onaylandi = 182,
            Karsilaniyor = 183,
            Karsilandi = 184
        }

        public enum MahalTur
        {
            Etap = 163,
            Bolum = 164,
            Blok = 165,
            Kat = 166
        }
        public enum OnayDurumu
        {
            Bekliyor = 1,
            Onaylandi = 3,
            GeriGonderildi = 4,
            Iptal = 5
        }

        public enum SiparisDurumIKodu
        {
            Bekliyor = 1,
            OnaySurecinde = 2,
            Onaylandi = 3,
            GeriGonderildi = 4,
            Iptal = 5
        }

        public enum FaturaTipi
        {
            SatinAlmaFaturasi = 1,
            SatinAlmaIadeFaturasi = 6,
            SatisFaturasi = 8,
            SatinAlmaFiyatFarkiFaturasi = 13
        }

        public enum FaturaDurumIKodu
        {
            Bekliyor = 1,
            OnaySurecinde = 2,
            Onaylandi = 3,
            GeriGonderildi = 4,
            Iptal = 5
        }

        public enum TalepDurumIKodu
        {
            Bekliyor = 1,
            OnaySurecinde = 2,
            Onaylandi = 3,
            Karsilaniyor = 4,
            Karsilandi = 5,
            Iptal = 6,
            GeriGonderildi = 7
        }
    }
}
