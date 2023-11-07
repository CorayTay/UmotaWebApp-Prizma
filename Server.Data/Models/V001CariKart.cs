using System;
using System.Collections.Generic;

#nullable disable

namespace UmotaWebApp.Server.Data.Models
{
    public partial class V001CariKart
    {
        public int Logref { get; set; }
        public byte? Caritip { get; set; }
        public string Caritipadi { get; set; }
        public string Kodu { get; set; }
        public string Adi { get; set; }
        public string Adres1 { get; set; }
        public string Adres2 { get; set; }
        public string Semt { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public string Ulke { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Faks { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
        public string Postakodu { get; set; }
        public string Vdno { get; set; }
        public string Vdadi { get; set; }
        public string Ozelkod { get; set; }
        public string Ozelkod2 { get; set; }
        public string Ozelkod3 { get; set; }
        public string Ozelkod4 { get; set; }
        public string Ozelkod5 { get; set; }
        public int? Odemeplanref { get; set; }
        public short? Active { get; set; }
        public int? lgfirmano { get; set; }
    }
}
