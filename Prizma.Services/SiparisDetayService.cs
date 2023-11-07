using AutoMapper;
using FluentValidation;
using Prizma.Core;
using Prizma.Core.Model;
using Prizma.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared.ModelDto.Request;
using static Dapper.SqlMapper;

namespace Prizma.Services
{
    public class SiparisDetayService : ISiparisDetayService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper Mapper;

        public SiparisDetayService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            Mapper = mapper;
        }
        public async Task<IEnumerable<V041_SiparisDetay>> GetSiparisDetayListAsnyc(SiparisDetayRequestDto request)
        {
            return await _unitOfWork.SiparisDetayRepository.GetSiparisDetayListAsnyc(request);
        }

        public async Task<SiparisDetay> CreateSiparisDetay(SiparisDetayDto entity)
        {
            var sipdetay = Mapper.Map<SiparisDetayDto, SiparisDetay>(entity);

            await _unitOfWork.SiparisDetayRepository.AddAsync(sipdetay);
            await _unitOfWork.CommitAsync();

            return sipdetay;
        }

        public async Task<SiparisDetay> GetSiparisDetay(int logref)
        {
            return await _unitOfWork.SiparisDetayRepository.SingleOrDefaultAsync(x => x.logref == logref);
        }
        public async Task<SiparisDetay> Update(SiparisDetayRequestDto entity)
        {
            var sipdetay = Mapper.Map<SiparisDetayDto, SiparisDetay>(entity.SiparisDetay);

            _unitOfWork.SiparisDetayRepository.Update(sipdetay);
            await _unitOfWork.CommitAsync();

            return sipdetay;
        }
    }
}
