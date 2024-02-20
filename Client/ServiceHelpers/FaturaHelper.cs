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
    public class FaturaHelper : IDataHelper<FaturaDto, FaturaRequestDto>
    {
        public HttpClient httpClient { get; set; }
        public ILocalStorageService LocalStorageService { get; set; }

        public FaturaHelper(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            this.httpClient = httpClient;
            LocalStorageService = localStorageService;
        }

        public Task<FaturaDto> DeleteRecord(FaturaDto request)
        {
            throw new System.NotImplementedException();
        }

        public Task<FaturaDto> LoadRecord(int logref)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<FaturaDto>> LoadRecords()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<FaturaDto>> LoadRecords(FaturaRequestDto request)
        {
            throw new System.NotImplementedException();
        }

        public Task<FaturaDto> SaveRecord(FaturaDto request)
        {
            throw new System.NotImplementedException();
        }

        public Task<FaturaDto> UpdateRecord(FaturaDto request)
        {
            throw new System.NotImplementedException();
        }
        public async Task<List<V047_Fatura>> LoadRecordsFromView(FaturaRequestDto request)
        {
            var selectedFirmaDonem = await LocalStorageService.GetItemAsync<SisFirmaDonemDto>(Consts.FirmaDonem);

            if (selectedFirmaDonem == null)
                throw new Exception("Firma Dönem Seçili değil");

            request.FirmaId = selectedFirmaDonem.firma_no.Value;

            var kullanicikodu = await LocalStorageService.GetItemAsync<string>(Consts.KullaniciKodu);
            request.kullanicikodu = kullanicikodu;

            var result = await httpClient.PostGetServiceResponseAsync<List<V047_Fatura>, FaturaRequestDto>(UrlHelper.FaturaLoadRecordsFromView, request, ThrowSuccessException: true);

            return result;
        }

    }
}
