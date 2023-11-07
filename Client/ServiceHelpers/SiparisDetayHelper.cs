using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UmotaWebApp.Client.Utils;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared.ModelDto.Request;

namespace UmotaWebApp.Client.ServiceHelpers
{
    public class SiparisDetayHelper : IDataHelper<SiparisDetayDto, SiparisDetayRequestDto>
    {
        public HttpClient httpClient { get; set; }
        public ILocalStorageService LocalStorageService { get; set; }

        public SiparisDetayHelper(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            this.httpClient = httpClient;
            LocalStorageService = localStorageService;
        }

        public Task<SiparisDetayDto> DeleteRecord(SiparisDetayDto request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SiparisDetayDto> LoadRecord(int logref)
        {
            var selectedFirmaDonem = await LocalStorageService.GetItemAsync<SisFirmaDonemDto>(Consts.FirmaDonem);

            if (selectedFirmaDonem == null)
                throw new Exception("Firma Dönem Seçili değil");

            var kullanicikodu = await LocalStorageService.GetItemAsync<string>(Consts.KullaniciKodu);


            var request = new SiparisDetayRequestDto();
            request.SiparisDetay = new SiparisDetayDto() { Logref = logref };
            request.FirmaId = selectedFirmaDonem.firma_no.Value;

            var result = await httpClient.PostGetServiceResponseAsync<SiparisDetayDto, SiparisDetayRequestDto>(UrlHelper.SiparisDetayGetir, request, ThrowSuccessException: true);

            return result;
        }

        public Task<List<SiparisDetayDto>> LoadRecords()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<SiparisDetayDto>> LoadRecords(SiparisDetayRequestDto request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SiparisDetayDto> SaveRecord(SiparisDetayDto td)
        {
            var selectedFirmaDonem = await LocalStorageService.GetItemAsync<SisFirmaDonemDto>(Consts.FirmaDonem);

            if (selectedFirmaDonem == null)
                throw new Exception("Firma Dönem Seçili değil");

            var kullanicikodu = await LocalStorageService.GetItemAsync<string>(Consts.KullaniciKodu);

            td.Insdate = DateTime.Now;
            td.Insuser = kullanicikodu;
            td.Status = 0;

            var request = new SiparisDetayRequestDto();
            request.SiparisDetay = td;
            request.FirmaId = selectedFirmaDonem.firma_no.Value;

            var result = await httpClient.PostGetServiceResponseAsync<SiparisDetayDto, SiparisDetayRequestDto>(UrlHelper.SiparisDetayKaydet, request, ThrowSuccessException: true);

            return result;
        }

        public async Task<SiparisDetayDto> UpdateRecord(SiparisDetayDto td)
        {
            var selectedFirmaDonem = await LocalStorageService.GetItemAsync<SisFirmaDonemDto>(Consts.FirmaDonem);

            if (selectedFirmaDonem == null)
                throw new Exception("Firma Dönem Seçili değil");

            var kullanicikodu = await LocalStorageService.GetItemAsync<string>(Consts.KullaniciKodu);

            td.Upddate = DateTime.Now;
            td.Upduser = kullanicikodu;

            var request = new SiparisDetayRequestDto();
            request.SiparisDetay = td;
            request.FirmaId = selectedFirmaDonem.firma_no.Value;

            var result = await httpClient.PostGetServiceResponseAsync<SiparisDetayDto, SiparisDetayRequestDto>(UrlHelper.SiparisDetayGuncelle, request, ThrowSuccessException: true);

            return result;
        }
        public async Task<List<V041_SiparisDetay>> LoadViewRecords(SiparisDetayRequestDto request)
        {
            var selectedFirmaDonem = await LocalStorageService.GetItemAsync<SisFirmaDonemDto>(Consts.FirmaDonem);
            if (selectedFirmaDonem == null)
                throw new Exception("Firma Dönem Seçili değil");
            var kullanicikodu = await LocalStorageService.GetItemAsync<string>(Consts.KullaniciKodu);

            var result = await httpClient.PostGetServiceResponseAsync<List<V041_SiparisDetay>, SiparisDetayRequestDto>(UrlHelper.SiparisV041SiparisDetayList, request);

            return result;
        }
    }
}
