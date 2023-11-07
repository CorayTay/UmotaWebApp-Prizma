using Prizma.Core.Model;
using Prizma.Core;
using Prizma.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto.Request;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared;

namespace Prizma.Services
{
    public class SiparisOnayService : ISiparisOnayService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SiparisOnayService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<V042_SiparisOnay>> GetSiparisFisOnayListAsnyc(SiparisOnayRequestDto request)
        {
            return await _unitOfWork.SiparisOnayRepository.GetSiparisFisOnayListAsnyc(request);
        }

        public async Task<int> SiparisDurumGuncelle(SiparisOnayRequestDto request)
        {
            return await _unitOfWork.SiparisOnayRepository.SiparisDurumGuncelle(request);
        }

        public async Task<int> SiparisOnayRota(SiparisOnayRequestDto request)
        {
            return await _unitOfWork.SiparisOnayRepository.SiparisOnayRota(request);
        }

        public async Task<bool> UploadSiparisDosya(SiparisDosyaRequestDto request)
        {
            var td = SiparisDosya.Create(request.FileName, request.FileType, request.SiparisLogRef, request.InsUser);
            await _unitOfWork.SiparisDosyaRepository.CreateSiparisDosya(td);
            await _unitOfWork.CommitAsync();

            return true;
        }
        public async Task<int> SiparisGetOnayLineRef(SiparisOnayRequestDto request)
        {
            return await _unitOfWork.SiparisOnayRepository.SiparisGetOnayLineRef(request);
        }
        public async Task<int> SiparisOnayla(SiparisOnayRequestDto request)
        {
            return await _unitOfWork.SiparisOnayRepository.SiparisOnayla(request);
        }

    }
}
