using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prizma.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared.ServiceResponses;
using UmotaWebApp.Shared;

namespace UmotaWebApp.Server.Controllers.Prizma
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaturaController : ControllerBase
    {
        private readonly IFaturaService _faturaService;
        private readonly IMapper _mapper;
        private ILogger<SiparisController> Logger { get; }
        public FaturaController(IFaturaService faturaService, IMapper mapper, ILogger<SiparisController> logger)
        {
            _faturaService = faturaService;
            _mapper = mapper;
            Logger = logger;
        }

        [HttpPost("LoadRecordsFromView")]
        public async Task<ServiceResponse<List<V047_Fatura>>> LoadRecordsFromView(FaturaRequestDto request)
        {
            var result = new ServiceResponse<List<V047_Fatura>>();
            try
            {
                var response = await _faturaService.LoadRecordsFromView(request);
                result.Value = response;
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
