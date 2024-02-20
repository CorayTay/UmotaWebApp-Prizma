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

namespace Prizma.Services
{
    public class TalepFisService : ITalepFisService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TalepFisService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TalepFis> CreateTalepFis(TalepFisDto tf)
        {
            var yeniTalep = TalepFis.Create(tf.logref, tf.TurRef, tf.ProjeRef, tf.TalepEden, tf.LgFirmaNo);
            yeniTalep.ChangeTeslimatBilgileri(tf.TeslimYeriRef, tf.TeslimTarihi);
            yeniTalep.ChangeAciklama(tf.Aciklama);
            yeniTalep.ChangeFisNo(tf.FisNo);
            yeniTalep.ChangeInserter(tf.insuser);
            yeniTalep.ChangeOncelik(tf.Oncelik);

            var talepValidator = new TalepFisValidator();
            talepValidator.ValidateAndThrow(yeniTalep);

            await _unitOfWork.TalepFisRepository.CreateTalepFisAsync(yeniTalep);
            await _unitOfWork.CommitAsync();

            return yeniTalep;
        }

        public async Task<List<TalepFisDto>> GetTalepFisListAsync(TalepFisRequestDto request)
        {
            return await _unitOfWork.TalepFisRepository.GetTalepFisListAsync(request.kullanicikodu);
        }

        public async Task<List<V030_TalepFis>> GetV030_TalepFisListAsync(TalepFisRequestDto request)
        {
            return await _unitOfWork.TalepFisRepository.GetV030_TalepFisListAsync(request);
        }

        public async Task<TalepFis> UpdateTalepFis(TalepFisDto talepFisDto)
        {
            var row = await _unitOfWork.TalepFisRepository.SingleOrDefaultAsync(x => x.logref == talepFisDto.logref);

            if (row == null)
                throw new System.NullReferenceException("Talep bulunamadı");

            row.UpdateTalepFis(talepFisDto);

            await _unitOfWork.CommitAsync();
            return row;
        }
    }
}
