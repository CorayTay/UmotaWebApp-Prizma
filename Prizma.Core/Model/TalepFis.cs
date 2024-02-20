using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto;
using static UmotaWebApp.Shared.Enum.SharedEnums;

namespace Prizma.Core.Model
{
    public class TalepFis : BaseEntity
    {
        #region Alanlar

        public string FisNo { get; private set; }
        public DateTime Tarih { get; private set; }
        public DateTime Saat { get; private set; }
        public int TurRef { get; private set; }
        public int ProjeRef { get; private set; }
        public string? TalepEden { get; private set; }
        public DateTime TeslimTarihi { get; private set; }
        public int DurumRef { get; private set; }
        public byte Oncelik { get; private set; }
        public string? Aciklama { get; private set; }
        public int? LgFirmaNo { get; private set; }
        public int TeslimYeriRef { get; private set; }
               

        #endregion

        private static TalepFis _talepFis = new TalepFis() { FisNo = "000", Tarih = DateTime.Now, Saat = DateTime.Now, TurRef = 188, Aciklama = "", DurumRef = (int)TalepFisDurum.Oneri, Oncelik = 2, TalepEden = "Umota", insdate = DateTime.Now, insuser = "Umota", TeslimTarihi = DateTime.Now.AddDays(3), TeslimYeriRef = 187};

        private TalepFis()
        {
            
        }

        public static TalepFis Create(int logref, int? tur, int? proje, string talepEden, int? lgfirmano)
        {
            TalepFis yeniTalepFis = (TalepFis)_talepFis.MemberwiseClone();
            yeniTalepFis.TalepEden = talepEden;
            yeniTalepFis.TurRef = tur.HasValue ? tur.Value : 0;
            yeniTalepFis.ProjeRef = proje.HasValue ? proje.Value : 0;
            yeniTalepFis.logref = logref;
            yeniTalepFis.LgFirmaNo = lgfirmano;

            return yeniTalepFis;
        }

        public void ChangeOncelik(byte oncelik)
        {
            this.Oncelik = oncelik;
        }

        public void ChangeInserter(string insuser)
        {
            this.insuser = insuser;
        }

        public void ChangeFisNo(string fisno)
        {
            this.FisNo = fisno;
        }

        public void ChangeDurum(TalepFisDurum durum)
        {
            this.DurumRef = (int)durum;
        }
        
        public void ChangeTeslimatBilgileri(int teslimYeri, DateTime teslimTarihi)
        {
            this.TeslimYeriRef = teslimYeri;
            this.TeslimTarihi = teslimTarihi;
        }

        public void ChangeAciklama(string aciklama)
        {
            this.Aciklama = aciklama;
        }
        
        public void UpdateTalepFis(TalepFisDto tf)
        {
            this.Aciklama = tf.Aciklama;
            this.TalepEden = tf.TalepEden;
            this.TeslimTarihi = tf.TeslimTarihi;
            this.TeslimYeriRef = tf.TeslimYeriRef;
            this.TurRef = tf.TurRef.HasValue ? tf.TurRef.Value : 188;
            this.ProjeRef = tf.ProjeRef.HasValue ? tf.ProjeRef.Value : 0;
            this.upduser = tf.upduser;
            this.upddate = tf.upddate;
        }
        
    }
}
