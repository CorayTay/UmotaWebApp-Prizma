using FluentValidation;
using Prizma.Core;
using Prizma.Core.Model;
using Prizma.Core.Repositories;
using Prizma.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared.ModelDto.Request;
using UmotaWebApp.Shared;

namespace Prizma.Services
{
    public class TalepDetayService : ITalepDetayService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TalepDetayService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TalepDetay> CreateTalepDetay(TalepDetayDTO td)
        {
            var yeniTalep = TalepDetay.Create(td.logref,td.ParLogRef, td.Aciklama, td.Miktar, td.BirimRef, td.Marka);

            yeniTalep.ChangeMahal(td.mahal1ref,td.mahal2ref,td.mahal3ref,td.mahal4ref,td.mahal5ref);
            yeniTalep.ChangeAktivite(td.Aktivite1Ref, td.Aktivite2Ref, td.Aktivite3Ref);
            yeniTalep.ChangeKaynak(td.KaynakRef);
            yeniTalep.ChangeTeslimat(td.TeslimYeriRef, td.TeslimTarihi);
            yeniTalep.ChangeInserter(td.insuser, td.insdate.Value);

            var validator = new TalepDetayValidator();
            validator.ValidateAndThrow(yeniTalep);

            await _unitOfWork.TalepDetayRepository.AddAsync(yeniTalep);
            await _unitOfWork.CommitAsync();

            return yeniTalep;
        }

        public async Task<TalepDetay> GetTalepDetay(int logref)
        {
            return await _unitOfWork.TalepDetayRepository.SingleOrDefaultAsync(x => x.logref == logref);
        }

        public async Task<IEnumerable<TalepDetay>> GetTalepDetayList()
        {
            return await _unitOfWork.TalepDetayRepository.GetTalepDetayListAsync();
        }

        public async Task<IEnumerable<V031_TalepDetay>> GetTalepFisDetayListAsnyc(TalepFisDetayRequestDto request)
        {
            return await _unitOfWork.TalepDetayRepository.GetTalepFisDetayListAsnyc(request);
        }

        public async Task<TalepDetay> Update(TalepDetayRequestDto talepDetay)
        {
            var td = talepDetay.TalepDetay;

            var row = await _unitOfWork.TalepDetayRepository.SingleOrDefaultAsync(x => x.logref == td.logref);

            row.upddate = td.upddate;
            row.upduser = td.upduser;

            row.ChangeAktivite(td.Aktivite1Ref, td.Aktivite2Ref, td.Aktivite3Ref);
            row.ChangeMahal(td.mahal1ref, td.mahal2ref,td.mahal3ref,td.mahal4ref,td.mahal5ref);
            row.ChangeMiktar(td.Miktar, td.BirimRef);
            row.ChangeTeslimat(td.TeslimYeriRef, td.TeslimTarihi);
            row.ChangeMarka(td.Marka);

            _unitOfWork.TalepDetayRepository.Update(row);
            await _unitOfWork.CommitAsync();

            return row;
        }
    }
}
