using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmotaWebApp.Client.Utils
{
    public class Consts
    {
        #region ülkeler
        public static string[] Ulkeler = { "Rusya",
"Antarktika",
"Kanada",
"Çin",
"Amerika Birleşik Devletleri",
"Brezilya",
"Avustralya",
"Hindistan",
"Arjantin",
"Kazakistan",
"Cezayir",
"Demokratik Kongo Cumhuriyeti",
"Grönland (Danimarka)",
"Suudi Arabistan",
"Meksika",
"Endonezya",
"Sudan",
"Libya",
"İran",
"Moğolistan",
"Peru",
"Çad",
"Nijer",
"Angola",
"Mali",
"Güney Afrika",
"Kolombiya",
"Etiyopya",
"Bolivya",
"Moritanya",
"Mısır",
"Tanzanya",
"Nijerya",
"Venezuela",
"Pakistan",
"Namibya",
"Mozambik",
"Türkiye",
"Şili",
"Zambiya",
"Burma",
"Afganistan",
"Güney Sudan",
"Fransa",
"Somali",
"Orta Afrika Cumhuriyeti",
"Ukrayna",
"Madagaskar",
"Botsvana",
"Kenya",
"Yemen",
"Tayland",
"İspanya",
"Türkmenistan",
"Kamerun",
"Papua Yeni Gine",
"İsveç",
"Özbekistan",
"Fas",
"Irak",
"Paraguay",
"Zimbabve",
"Japonya",
"Almanya",
"Filipinler",
"Kongo Cumhuriyeti",
"Finlandiya",
"Vietnam",
"Malezya",
"Norveç",
"Fildişi Sahili",
"Polonya",
"Umman",
"İtalya",
"Burkina Faso",
"Yeni Zelanda",
"Gabon",
"Batı Sahra",
"Ekvador",
"Gine",
"Birleşik Krallık",
"Uganda",
"Gana",
"Romanya",
"Laos",
"Guyana",
"Beyaz Rusya",
"Kırgızistan",
"Senegal",
"Suriye",
"Kamboçya",
"Uruguay",
"Surinam",
"Tunus",
"Bangladeş",
"Nepal",
"Tacikistan",
"Somaliland",
"Yunanistan",
"Nikaragua",
"Kuzey Kore",
"Malavi",
"Eritre",
"Benin",
"Honduras",
"Liberya",
"Bulgaristan",
"Küba",
"Guatemala",
"İzlanda",
"Güney Kore",
"Macaristan",
"Portekiz",
"Ürdün",
"Sırbistan",
"Azerbaycan",
"Avusturya",
"Birleşik Arap Emirlikleri",
"Çek Cumhuriyeti",
"Panama",
"Sierra Leone",
"İrlanda",
"Gürcistan",
"Sri Lanka",
"Litvanya",
"Letonya",
"Svalbard ve Jan Mayen (Norveç)",
"Togo",
"Hırvatistan",
"Bosna-Hersek",
"Kosta Rika",
"Slovakya",
"Dominik Cumhuriyeti",
"Estonya",
"Danimarka",
"Hollanda",
"İsviçre",
"Bhutan",
"Tayvan",
"Gine Bissau",
"Moldova",
"Belçika",
"Lesoto",
"Ermenistan",
"Solomon Adaları",
"Arnavutluk",
"Ekvator Ginesi",
"Burundi",
"Haiti",
"Ruanda",
"Makedonya",
"Cibuti",
"Belize",
"El Salvador",
"İsrail",
"Slovenya",
"Yeni Kaledonya (Fransa)",
"Fiji",
"Kuveyt",
"Svaziland",
"Doğu Timor",
"Bahamalar",
"Karadağ",
"Vanuatu",
"Falkland Adaları (Birleşik Krallık)",
"Katar",
"Dağlık Karabağ",
"Gambiya",
"Jamaika",
"Kosova",
"Lübnan",
"Kıbrıs Cumhuriyeti",
"Porto Riko (ABD)",
"Abhazya",
"Fransız Güney ve Antarktika Toprakları (Fransa)",
"Pasifik Uzak Adaları Deniz Ulusal Anıtı",
"Filistin",
"Brunei",
"Trinidad ve Tobago",
"Transdinyester",
"Yeşil Burun Adaları",
"Fransız Polinezyası (Fransa)",
"Güney Georgia ve Güney Sandwich Adaları (Birleşik Krallık)",
"Güney Osetya",
"Kuzey Kıbrıs",
"Samoa",
"Lüksemburg",
"Mauritius",
"Komorlar",
"Faroe Adaları (Danimarka)",
"Hong Kong (Çin)",
"São Tomé ve Príncipe",
"Turks ve Caicos Adaları (Birleşik Krallık)",
"Kiribati",
"Bahreyn",
"Dominika",
"Tonga",
"Singapur",
"Mikronezya Federal Devletleri",
"Saint Lucia",
"Man Adası (Birleşik Krallık)",
"Guam (ABD)",
"Andorra",
"Kuzey Mariana Adaları (ABD)",
"Palau",
"Seyşeller",
"Curaçao (Hollanda)",
"Antigua ve Barbuda",
"Barbados",
"Heard Adası ve McDonald Adaları (Avustralya)",
"Saint Vincent ve Grenadinler",
"Svalbard ve Jan Mayen (Norveç)",
"ABD Virjin Adaları (ABD)",
"Grenada",
"Malta",
"Saint Helena (Birleşik Krallık)",
"Maldivler",
"Cayman Adaları (Birleşik Krallık)",
"Saint Kitts ve Nevis",
"Niue (Yeni Zelanda)",
"Ağrotur ve Dikelya (Birleşik Krallık)",
"Saint Pierre ve Miquelon (Fransa)",
"Cook Adaları (Yeni Zelanda)",
"Amerikan Samoası (ABD)",
"Marshall Adaları",
"Aruba (Hollanda)",
"Lihtenştayn",
"Britanya Virjin Adaları (Birleşik Krallık)",
"Wallis ve Futuna (Fransa)",
"Christmas Adası (Avustralya)",
"Jersey (Birleşik Krallık)",
"Montserrat (Birleşik Krallık)",
"Anguilla (Birleşik Krallık)",
"Guernsey (Birleşik Krallık)",
"San Marino",
"Britanya Hint Okyanusu Toprakları (Birleşik Krallık)",
"Saint Martin (Fransa)",
"Bermuda (Birleşik Krallık)",
"Bouvet Adası (Norway)",
"Pitcairn Adaları (Birleşik Krallık)",
"Norfolk Adası (Avustralya)",
"Sint Maarten (Hollanda)",
"Makao (Çin)",
"Tuvalu",
"Nauru",
"Saint Barthélemy (Fransa)",
"Cocos Adaları (Avustralya)",
"Tokelau (Yeni Zelanda)",
"Cebelitarık (Birleşik Krallık)",
"Wake Adası (ABD)",
"Clipperton Adası (Fransa)",
"Navassa Adası (ABD)",
"Ashmore ve Cartier Adaları (Avustralya)",
"Spratly Adaları (tartışmalı)",
"Mercan Denizi Adaları (Avustralya)",
"Monako",
"Vatikan","İngiltere"};
        #endregion

        public const string KullaniciKodu = "kullanicikodu";
        public const string FirmaDonem = "firmaNo";
        public const string FirmaDonemYetki = "firmadonemyetki";
        public const string Token = "token";
        public const string CompanyLogo = "companyLogo";
        public const string DonemFirmalar = "donemFirmalar";
        public const string OndegerFirmaDonem = "odfirmaNo";
        public const string MakpaFirmaNo = "101";
        public const string MakpaLogoFirmaNo = "102";
        public const string GASTROMOREFirmaNo = "200";

        public const string KullaniciYetkisi_KaynakOnaylama = "Y001";
        public const string KullaniciYetkisi_TumTalepleriGorme = "Y002";
        public const string KullaniciYetkisi_TalepOzelOnay = "Y003";
        public const string KullaniciYetkisi_TalepStokGirebilir = "Y004";
        public const string KullaniciYetkisi_SiparisOzelOnay = "Y005";
        public const string KullaniciYetkisi_SozlesmeOzelOnay = "Y006";
        public const string KullaniciYetkisi_HakedisOzelOnay = "Y007";
        public const string KullaniciYetkisi_AktiviteOnaylama = "Y008";
        public const string KullaniciYetkisi_TumProjeleriGorme = "Y009";
        public const string KullaniciYetkisi_TumProjeTalepleriGorme = "Y010";
        public const string KullaniciYetkisi_TumSiparisleriGorme = "Y011";
        public const string KullaniciYetkisi_TumProjeSiparisleriGorme = "Y012";
        public const string KullaniciYetkisi_TumIrsaliyeleriGorme = "Y013";
        public const string KullaniciYetkisi_TumProjeIrsaliyeleriGorme = "Y014";
        public const string KullaniciYetkisi_TumFaturalariGorme = "Y015";
        public const string KullaniciYetkisi_TumProjeFaturalariGorme = "Y016";
        public const string KullaniciYetkisi_FaturaOzelOnay = "Y017";
        public const string KullaniciYetkisi_HakedisYBFSatirOnay = "Y018";
        public const string KullaniciYetkisi_ButceOzelOnay = "Y019";
        public const string KullaniciYetkisi_HakedisOncekiMiktarGiris = "Y020";
        public const string KullaniciYetkisi_SiparisMiktarindanFazlaSatinalma = "Y021";
        public const string KullaniciYetkisi_MalzemeOnaylama = "Y022";
        public const string KullaniciYetkisi_HizmetOnaylama = "Y023";
        public const string KullaniciYetkisi_MalzemeFisOzelOnay = "Y024";
        public const string KullaniciYetkisi_HakedisBirimFiyatDegistirme = "Y025";
        public const string KullaniciYetkisi_YoneticiMenu = "Y026";
        public const string KullaniciYetkisi_TopluOnay = "Y027";
        public const string KullaniciYetkisi_HakedisOzelSilme = "Y028";

        public const string PARAM_MODUL_TANIMLAR = "100";
        public const string PARAM_MODUL_SATINALMA = "200";
        public const string PARAM_MODUL_HAKEDIS = "500";

        public const string PARAM_TANIMLAR_AKTIVITE_SEVIYESI = "101";
        public const string PARAM_TANIMLAR_KAYNAKKODU_SEVIYESI = "102";
        public const string PARAM_TANIMLAR_CARIOZELKODU_ALANI = "103";
        public const string PARAM_TANIMLAR_CARIOZELKODU_DEGERI = "104";
        public const string PARAM_TANIMLAR_MALZEMEOZELKODU_ALANI = "105";
        public const string PARAM_TANIMLAR_MALZEMEOZELKODU_DEGERI = "106";
        public const string PARAM_TANIMLAR_MALZEME_LOGO_BIRIMSETIKODU = "107";

        public const string PARAM_SATINALMA_SIPDOVIZKURTURU = "201";

        public const string PARAM_HAKEDIS_YEMEKKESINTI_MALZEMEKODU = "501";
        public const string PARAM_HAKEDIS_YEMEKKESINTI_MALZEMEADI = "502";
        public const string PARAM_HAKEDIS_YEMEKKESINTI_KDVYUZ = "503";
        public const string PARAM_HAKEDIS_SAGLIKKESINTI_MALZEMEKODU = "504";
        public const string PARAM_HAKEDIS_SAGLIKKESINTI_MALZEMEADI = "505";
        public const string PARAM_HAKEDIS_SAGLIKKESINTI_KDVYUZ = "506";
        public const string PARAM_HAKEDIS_KAMPKESINTI_MALZEMEKODU = "507";
        public const string PARAM_HAKEDIS_KAMPKESINTI_MALZEMEADI = "508";
        public const string PARAM_HAKEDIS_KAMPKESINTI_KDVYUZ = "509";
        public const string PARAM_HAKEDIS_SIGORTAKESINTI_MALZEMEKODU = "510";
        public const string PARAM_HAKEDIS_SIGORTAKESINTI_MALZEMEADI = "511";
        public const string PARAM_HAKEDIS_SIGORTAKESINTI_KDVYUZ = "512";
        public const string PARAM_HAKEDIS_CEZAKESINTI_MALZEMEKODU = "513";
        public const string PARAM_HAKEDIS_CEZAKESINTI_MALZEMEADI = "514";
        public const string PARAM_HAKEDIS_CEZAKESINTI_KDVYUZ = "515";
        public const string PARAM_HAKEDIS_DIGERKESINTI_MALZEMEKODU = "516";
        public const string PARAM_HAKEDIS_DIGERKESINTI_MALZEMEADI = "517";
        public const string PARAM_HAKEDIS_DIGERKESINTI_KDVYUZ = "518";
        public const string PARAM_HAKEDIS_TUTANAKLI_ISLER_KAYNAKKODU = "519";



        public const string TeklifSozlesmesi = @"1.Fiyatlarımıza KDV dahil değildir. Teklifteki fiyatlarımız iskonto yapılmış net fiyatlardır. 
2.Döviz kuru ödemenin gerçekleştiği veya faturanın kesildiği günden hesaplanacaktır. GARANTİ bankası döviz satış kuru esas alınacaktır.   
3.Her türlü tesisat işleri (Elektrik, Sıcak-Soğuk Su, Sifon ve Sübab, LG,NG veya Havagazı ,Havalandırma vs….)teklif dışıdır. 
4.Teslim Süresi: Sipariş onayı ile stokta olan ürünler hemen, olmayanlar 4-6 haftadır. 
5.Ödeme Şekli: Sipariş onayı ile %50 peşin kalanı mal tesliminden önce. 
6.Nakliye: Nakliye dahil değildir. Ürünlerin mahallere taşınması alıcıya aittir. 
Ürünlerin mahaller taşınması için gerekli her türlü vinç, forklift vb. taşıma aletlerinin temini alıcıya aittir. 
7.Montaj: Türkiye içi montaj hizmeti verilebilir. Ücreti anlaşmaya bağlıdır. 
8.Proje kapsamında yapılan özel imalat ürünler kesinlikle iade alınmaz. 
9.Montaj: Proje montajı esnasında ALICI imza yetkilisinin şantiyede bulunması ve 'Proje Montaj Tutanağı' nı kaşeli olarak imzalaması zorunludur. 
10.Remote soğutmalı bütün üniteler için, ( soğuk oda, derin dondurucu, buzdolabı vb.) 10 mt ye kadar borulama fiyat teklife dahildir. 
Bu mesafe üzeri ayrıca fiyatlandırılacaktır.
11.Soğuk oda- derin dondurucu  ünitelerin zemin ile ilgili yapılacak her türlü inşai işler (zemin fayans, izolasyon vs.) 
ve dış ünitelerin koyulacağı yerdeki demir taşıyıcı karkaslar alıcı teminidir.
12.Teklifin geçerlilik süresi 2 gündür.

BANKA HESAP BİLGİLERİ
Garanti Bankası	İmes 434/6293378  TR64 0006 2000 4340 0006 2933 78
";

        public const string TeklifSozlesmesiMakpa = @"1.Fiyatlarımıza KDV dahil değildir. Teklifteki fiyatlarımız iskonto yapılmış net fiyatlardır. 
2.Döviz kuru ödemenin gerçekleştiği veya faturanın kesildiği günden hesaplanacaktır. GARANTİ bankası döviz satış kuru esas alınacaktır.   
3.Her türlü tesisat işleri (Elektrik, Sıcak-Soğuk Su, Sifon ve Sübab, LG,NG veya Havagazı ,Havalandırma vs….)teklif dışıdır. 
4.Teslim Süresi: Sipariş onayı ile stokta olan ürünler hemen, olmayanlar 4-6 haftadır. 
5.Ödeme Şekli: Sipariş onayı ile %50 peşin kalanı mal tesliminden önce. 
6.Nakliye: Nakliye dahil değildir. Ürünlerin mahallere taşınması alıcıya aittir. 
Ürünlerin mahaller taşınması için gerekli her türlü vinç, forklift vb. taşıma aletlerinin temini alıcıya aittir. 
7.Montaj: Türkiye içi montaj hizmeti verilebilir. Ücreti anlaşmaya bağlıdır. 
8.Proje kapsamında yapılan özel imalat ürünler kesinlikle iade alınmaz. 
9.Montaj: Proje montajı esnasında ALICI imza yetkilisinin şantiyede bulunması ve 'Proje Montaj Tutanağı' nı kaşeli olarak imzalaması zorunludur. 
10.Remote soğutmalı bütün üniteler için, ( soğuk oda, derin dondurucu, buzdolabı vb.) 10 mt ye kadar borulama fiyat teklife dahildir. 
Bu mesafe üzeri ayrıca fiyatlandırılacaktır.
11.Soğuk oda- derin dondurucu  ünitelerin zemin ile ilgili yapılacak her türlü inşai işler (zemin fayans, izolasyon vs.) 
ve dış ünitelerin koyulacağı yerdeki demir taşıyıcı karkaslar alıcı teminidir.
12.Teklifin geçerlilik süresi 2 gündür.

GARANTİ BANKASI-İMES SANAYİ ŞUBESİ
TL TR41 0006 2000 4340 0006 2878 75";
    }

    public class Mesajlar
    {
        public const string MetinGir = "Aranacak metni giriniz.";
        public const string Seciniz = "Seçiniz...";
    }

    public class SabitTip
    {
        public const int DovizKodlari = 1;
        public const int TeklifDurumu = 10;
    }

    public static class ExtensionHelpers
    {
        public static string ClearCharacters(this string str)
        {
            var cleanStr = str.Replace("'", "");
            cleanStr = cleanStr.Replace("\"", "");
            cleanStr = cleanStr.Replace(@"\U0130", "I");
            
            return cleanStr;
        }

    }
}
