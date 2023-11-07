using Prizma.Core;
using Prizma.Core.Model;
using Prizma.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto;

namespace Prizma.Services
{
    public class SiparisDosyaService : ISiparisDosyaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SiparisDosyaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<SiparisDosya> CreateSiparisDosya(SiparisDosyaDto siparisDosya)
        {
            var sipdosyasi = SiparisDosya.Create(siparisDosya.DosyaAdi, siparisDosya.DosyaTipi, siparisDosya.SiparisLogRef, siparisDosya.InsUser);

            await _unitOfWork.SiparisDosyaRepository.CreateSiparisDosya(sipdosyasi);
            await _unitOfWork.CommitAsync();

            return sipdosyasi;
        }

        public async Task<List<SiparisDosya>> GetDosyalar(int siparisref)
        {
            var result = await _unitOfWork.SiparisDosyaRepository.GetDosyalar(siparisref);
            return result;
        }
    }
}
