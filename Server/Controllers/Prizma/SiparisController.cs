using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prizma.Core.Services;
using Prizma.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared.ServiceResponses;
using UmotaWebApp.Shared;
using AutoMapper;
using UmotaWebApp.Shared.CustomException;
using UmotaWebApp.Shared.ModelDto.Request;
using System.Linq;
using Prizma.Core.Model;

namespace UmotaWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController : ControllerBase
    {
        private readonly ISiparisService _siparisService;
        private readonly ISiparisDetayService _siparisDetayService;
        private readonly ISiparisOnayService _siparisOnayService;
        private readonly ISiparisDosyaService _siparisDosyaService;
        private readonly IMapper _mapper;
        private ILogger<SiparisController> Logger { get; }
        public SiparisController(ISiparisService siparisService, ISiparisDetayService siparisDetayService, ISiparisOnayService siparisOnayService, ISiparisDosyaService siparisDosyaService, IMapper mapper, ILogger<SiparisController> logger)
        {
            _siparisService = siparisService;
            _siparisDetayService = siparisDetayService;
            _siparisOnayService = siparisOnayService;
            _siparisDosyaService = siparisDosyaService;
            _mapper = mapper;
            Logger = logger;
        }

        [HttpPost("LoadRecordsFromView")]
        public async Task<ServiceResponse<List<V040_Siparis>>> LoadRecordsFromView(SiparisRequestDto request)
        {
            var result = new ServiceResponse<List<V040_Siparis>>();
            try
            {
                var response = await _siparisService.LoadRecordsFromView(request);
                result.Value = response;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);
            }

            return result;
        }

        [HttpPost("LoadRecordFromView")]
        public async Task<ServiceResponse<SiparisDto>> LoadRecordFromView(SiparisRequestDto request)
        {
            var result = new ServiceResponse<SiparisDto>();
            try
            {
                var response = await _siparisService.LoadRecordFromView(request);
                result.Value = response;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);
            }

            return result;
        }

        [HttpPost("SaveRecord")]
        public async Task<ServiceResponse<SiparisDto>> SaveRecord(SiparisRequestDto request)
        {
            var result = new ServiceResponse<SiparisDto>();
            try
            {
                var response = await _siparisService.SaveRecord(request.SiparisDto);
                
                result.Value = request.SiparisDto;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);
            }

            return result;
        }

        [HttpPost("UpdateRecord")]
        public async Task<ServiceResponse<SiparisDto>> UpdateRecord(SiparisRequestDto request)
        {
            var result = new ServiceResponse<SiparisDto>();
            try
            {
                var response = await _siparisService.UpdateRecord(request.SiparisDto);

                result.Value = request.SiparisDto;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);
            }

            return result;
        }

        [HttpPost("GetSiparisDetay")]
        public async Task<ServiceResponse<SiparisDetayDto>> GetSiparisDetay(SiparisDetayRequestDto request)
        {
            var result = new ServiceResponse<SiparisDetayDto>();
            try
            {
                var response = await _siparisDetayService.GetSiparisDetay(request.SiparisDetay.Logref);
                var tdDto = _mapper.Map<SiparisDetay, SiparisDetayDto>(response);
                result.Value = tdDto;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);
            }

            return result;
        }

        [HttpPost("GetSiparisDetayListAsnyc")]
        public async Task<ServiceResponse<List<V041_SiparisDetay>>> GetSiparisDetayListAsnyc(SiparisDetayRequestDto request)
        {
            var result = new ServiceResponse<List<V041_SiparisDetay>>();
            try
            {
                var td = await _siparisDetayService.GetSiparisDetayListAsnyc(request);

                result.Value = td.ToList();

            }
            catch (ApiException ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);

            }
            catch (Exception ex)
            {
                result.SetException(ex);
                Logger.Log(LogLevel.Error, ex.Message);
            }

            return result;

        }

        [HttpPost("GetSiparisFisOnayListAsnyc")]
        public async Task<ServiceResponse<List<V042_SiparisOnay>>> GetSiparisFisOnayListAsnyc(SiparisOnayRequestDto request)
        {
            var result = new ServiceResponse<List<V042_SiparisOnay>>();
            try
            {
                var td = await _siparisOnayService.GetSiparisFisOnayListAsnyc(request);

                result.Value = td.ToList();

            }
            catch (ApiException ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);

            }
            catch (Exception ex)
            {
                result.SetException(ex);
                Logger.Log(LogLevel.Error, ex.Message);
            }

            return result;

        }

        [HttpPost("SiparisOnayRota")]
        public async Task<ServiceResponse<int>> SiparisOnayRota(SiparisOnayRequestDto request)
        {
            var result = new ServiceResponse<int>();

            try
            {
                result.Value = await _siparisOnayService.SiparisOnayRota(request);
            }
            catch (Exception ex)
            {
                result.SetException(ex);
                Logger.Log(LogLevel.Error, ex.Message);
            }

            return result;
        }

        [HttpPost("SiparisDurumGuncelle")]
        public async Task<ServiceResponse<int>> SiparisDurumGuncelle(SiparisOnayRequestDto request)
        {
            var result = new ServiceResponse<int>();

            try
            {
                result.Value = await _siparisOnayService.SiparisDurumGuncelle(request);
            }
            catch (Exception ex)
            {
                result.SetException(ex);
                Logger.Log(LogLevel.Error, ex.Message);
            }

            return result;
        }

        [HttpPost("UploadSiparisDosya")]
        public async Task<ServiceResponse<bool>> UploadSiparisDosya(SiparisDosyaRequestDto request)
        {
            var result = new ServiceResponse<bool>();

            try
            {
                result.Value = await _siparisOnayService.UploadSiparisDosya(request);
            }
            catch (Exception ex)
            {
                result.SetException(ex);
                Logger.Log(LogLevel.Error, ex.Message);
            }

            return result;
        }

        [HttpPost("GetSiparisDosyalar")]
        public async Task<ServiceResponse<List<SiparisDosyaDto>>> GetSiparisDosyalar([FromBody] int talepref)
        {
            var result = new ServiceResponse<List<SiparisDosyaDto>>();

            try
            {
                var response = await _siparisDosyaService.GetDosyalar(talepref);
                var td = _mapper.Map<IEnumerable<SiparisDosya>, IEnumerable<SiparisDosyaDto>>(response);

                result.Value = td.ToList();
            }
            catch (Exception ex)
            {
                result.SetException(ex);
                Logger.Log(LogLevel.Error, ex.Message);
            }

            return result;
        }

        [HttpPost("SiparisGetOnayLineRef")]
        public async Task<ServiceResponse<int>> SiparisGetOnayLineRef(SiparisOnayRequestDto request)
        {
            var result = new ServiceResponse<int>();

            try
            {
                result.Value = await _siparisOnayService.SiparisGetOnayLineRef(request);
            }
            catch (Exception ex)
            {
                result.SetException(ex);
                Logger.Log(LogLevel.Error, ex.Message);
            }

            return result;
        }

        [HttpPost("SiparisOnayla")]
        public async Task<ServiceResponse<int>> SiparisOnayla(SiparisOnayRequestDto request)
        {
            var result = new ServiceResponse<int>();

            try
            {
                result.Value = await _siparisOnayService.SiparisOnayla(request);
            }
            catch (Exception ex)
            {
                result.SetException(ex);
                Logger.Log(LogLevel.Error, ex.Message);
            }

            return result;
        }

        [HttpPost("CreateSiparisDetay")]
        public async Task<ServiceResponse<SiparisDetayDto>> CreateSiparisDetay(SiparisDetayRequestDto request)
        {
            var result = new ServiceResponse<SiparisDetayDto>();
            try
            {
                var response = await _siparisDetayService.CreateSiparisDetay(request.SiparisDetay);
                var tdDto = _mapper.Map<SiparisDetay, SiparisDetayDto>(response);
                result.Value = tdDto;

            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);
            }

            return result;
        }

        [HttpPost("UpdateSiparisDetay")]
        public async Task<ServiceResponse<SiparisDetayDto>> UpdateSiparisDetay(SiparisDetayRequestDto request)
        {
            var result = new ServiceResponse<SiparisDetayDto>();
            try
            {
                var response = await _siparisDetayService.Update(request);
                var tdDto = _mapper.Map<SiparisDetay, SiparisDetayDto>(response);
                result.Value = tdDto;

            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, ex.Message);
                result.SetException(ex);
            }

            return result;
        }


    }
}
