using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UmotaWebApp.Server.Services.Infrastructure;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.CustomException;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared.ServiceResponses;

namespace UmotaWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HelperController : ControllerBase
    {
        private readonly IRefGenerator RefService;
        private readonly ILogger<HelperController> Logger;
        private readonly IPersonelService PersonelService;
        

        public HelperController(IRefGenerator refGenerator, ILogger<HelperController> logger, IPersonelService personelService)
        {
            RefService = refGenerator;
            Logger = logger;
            PersonelService = personelService;
        }

        [HttpGet("GenerateRef")]
        public async Task<ServiceResponse<string>> GetRowRefNumber(string table, string keyField, string firmaId)
        {
            try
            {
                if (string.IsNullOrEmpty(table))
                    throw new ApiException("tablo adı boş geldi.Ref üretilemedi !");

                return new ServiceResponse<string>()
                {
                    Value = await RefService.GenerateRowRef(table, keyField, firmaId)
                };
            }
            catch (ApiException ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<string>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("GetTeslimSekliList")]
        public async Task<ServiceResponse<IEnumerable<string>>> GetTeslimSekliList()
        {
            try
            {
                var list = new List<string>();
                list.Add("MÜŞTERİ TESLİM");
                list.Add("ŞİRKETİMİZ DEPO TESLİM");
                list.Add("MÜŞTERİ ADRESİNE TESLİM");
                list.Add("KARGO ALICI ÖDEMELİ");
                list.Add("İHRACAT");

                return new ServiceResponse<IEnumerable<string>>()
                {
                    Value = await RefService.GetTeslimSekliList()
                };

            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<IEnumerable<string>>();
                e.SetException(ex);
                return e;
            }
        }


        [HttpGet("GetPersonelList")]
        public async Task<ServiceResponse<IEnumerable<PersonelDto>>> GetPersonelList(int logofirmno)
        {
            try
            {
                return new ServiceResponse<IEnumerable<PersonelDto>>()
                {
                    Value = await PersonelService.GetPersonelList(logofirmno)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<IEnumerable<PersonelDto>>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("GetOdemePlaniList")]
        public async Task<ServiceResponse<IEnumerable<OdemePlaniDto>>> GetOdemePlaniList(int logofirmno)
        {
            try
            {
                return new ServiceResponse<IEnumerable<OdemePlaniDto>>()
                {
                    Value = await RefService.GetOdemePlaniList(logofirmno)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<IEnumerable<OdemePlaniDto>>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("GetSabitDetayList")]
        public async Task<ServiceResponse<IEnumerable<SisSabitlerDetayDto>>> GetSabitDetayList(int tip)
        {
            try
            {
                return new ServiceResponse<IEnumerable<SisSabitlerDetayDto>>()
                {
                    Value = await RefService.GetSabitDetayList(tip)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<IEnumerable<SisSabitlerDetayDto>>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("GetKaynakList")]
        public async Task<ServiceResponse<IEnumerable<V002_Kaynak>>> GetKaynakList(int aktivite3LogRef)
        {
            try
            {
                return new ServiceResponse<IEnumerable<V002_Kaynak>>()
                {
                    Value = await RefService.GetKaynakList(aktivite3LogRef)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<IEnumerable<V002_Kaynak>>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("GetKaynakBirimKoduList")]
        public async Task<ServiceResponse<IEnumerable<SisSabitlerDetayDto>>> GetKaynakBirimKoduList(int kaynakLogRef)
        {
            try
            {
                return new ServiceResponse<IEnumerable<SisSabitlerDetayDto>>()
                {
                    Value = await RefService.GetKaynakBirimKoduList(kaynakLogRef)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<IEnumerable<SisSabitlerDetayDto>>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("GetMaxTalepFisNo")]
        public async Task<ServiceResponse<string>> GetMaxTalepFisNo(string projekodu, string talepturkodu)
        {
            try
            {
                return new ServiceResponse<string>()
                {
                    Value = await RefService.GetMaxTalepFisNo(projekodu, talepturkodu)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<string>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("RefNoAl")]
        public async Task<ServiceResponse<int>> RefNoAl(string tablename, string firmaId)
        {
            try
            {
                if (string.IsNullOrEmpty(tablename))
                    throw new ApiException("tablo adı boş geldi.Ref üretilemedi !");

                return new ServiceResponse<int>()
                {
                    Value = await RefService.RefNoAl(tablename, firmaId)
                };
            }
            catch (ApiException ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<int>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("GetCariSektorList")]
        public async Task<ServiceResponse<IEnumerable<SpeCodesDto>>> GetCariSektorList(int logofirmno)
        {
            try
            {
                return new ServiceResponse<IEnumerable<SpeCodesDto>>()
                {
                    Value = await RefService.GetCariSektorList(logofirmno)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<IEnumerable<SpeCodesDto>>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("FisNoAlLogo")]
        public async Task<ServiceResponse<string>> LogoFisNoAl(string table, string keyField, int firmaId, int logofirmaId)
        {
            try
            {
                if (string.IsNullOrEmpty(table))
                    throw new ApiException("tablo adı boş geldi.Ref üretilemedi !");

                return new ServiceResponse<string>()
                {
                    Value = await RefService.FisNoAlLogo(table, keyField, firmaId, logofirmaId)
                };
            }
            catch (ApiException ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<string>();
                e.SetException(ex);
                return e;
            }
        }

        [HttpGet("GetParamVal")]
        public async Task<ServiceResponse<string>> GetParamVal(string kodu)
        {
            try
            {
                return new ServiceResponse<string>()
                {
                    Value = await RefService.GetParamVal(kodu)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);

                var e = new ServiceResponse<string>();
                e.SetException(ex);
                return e;
            }
        }

    }
}
