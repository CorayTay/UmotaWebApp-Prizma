using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UmotaWebApp.Client.Utils;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ModelDto;

namespace UmotaWebApp.Client.ServiceHelpers
{    
    public class SabitHelper
    {
        public enum SabitTurler
        {
            DovizKodlari = 1,
            TalepTuru = 50,
            TalepDurumu = 51,
            TalepTeslimYeri = 52,
            TalepOnayTuru = 54,
            Birimler = 53,
            SiparisDurumu = 61,
            FaturaDurumu = 72
        }

        protected HttpClient httpClient { get; set; }

        protected ILocalStorageService LocalStorageService { get; set; }

        public SabitHelper(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            this.httpClient = httpClient;
            LocalStorageService = localStorageService;
        }

        public async Task<List<SisSabitlerDetayDto>> GetSabitDetay(SabitTurler tur)
        {
            var result = new List<SisSabitlerDetayDto>();
            try
            {
                result = await httpClient.GetServiceResponseAsync<List<SisSabitlerDetayDto>>("/api/helper/GetSabitDetayList?tip=" + (int)tur);
               
            }
            catch (Exception)
            {
            }

            return result;
        }

        public async Task<List<V002_Kaynak>> GetKaynakList(int aktivite3LogRef)
        {
            var result = new List<V002_Kaynak>();
            try
            {
                result = await httpClient.GetServiceResponseAsync<List<V002_Kaynak>>("/api/helper/GetKaynakList?aktivite3LogRef=" + aktivite3LogRef);

            }
            catch (Exception)
            {
            }

            return result;
        }

        public async Task<List<SisSabitlerDetayDto>> GetKaynakBirimKoduList(int kaynakLogRef)
        {
            var result = new List<SisSabitlerDetayDto>();
            try
            {
                result = await httpClient.GetServiceResponseAsync<List<SisSabitlerDetayDto>>("/api/helper/GetKaynakBirimKoduList?kaynakLogRef=" + kaynakLogRef);

            }
            catch (Exception)
            {
            }

            return result;
        }

        public async Task<string> GetMaxTalepFisNo(string projekodu, string talepturkodu)
        {
            var result = "000001";
            try
            {
                result = await httpClient.GetServiceResponseAsync<string>("/api/helper/GetMaxTalepFisNo?projekodu=" + projekodu + "&talepturkodu=" + talepturkodu);
            }
            catch (Exception)
            {
            }

            return result;
        }
        public async Task<string> GetParamVal(string kodu)
        {
            var result = "";
            try
            {
                result = await httpClient.GetServiceResponseAsync<string>("/api/helper/GetParamVal?kodu=" + kodu);
            }
            catch (Exception)
            {
            }

            return result;
        }
    }
}
