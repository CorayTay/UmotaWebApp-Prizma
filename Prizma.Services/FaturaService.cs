using AutoMapper;
using Prizma.Core;
using Prizma.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ModelDto;

namespace Prizma.Services
{
    public class FaturaService : IFaturaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper Mapper;

        public FaturaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            Mapper = mapper;
        }
        public async Task<List<V047_Fatura>> LoadRecordsFromView(FaturaRequestDto request)
        {
            return await _unitOfWork.FaturaRepository.LoadRecordsFromView(request);

        }
    }
}
