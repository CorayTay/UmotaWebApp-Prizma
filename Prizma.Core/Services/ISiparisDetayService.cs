using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto.Request;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ModelDto;
using Prizma.Core.Model;

namespace Prizma.Core.Services
{
    public interface ISiparisDetayService
    {
        Task<IEnumerable<V041_SiparisDetay>> GetSiparisDetayListAsnyc(SiparisDetayRequestDto request);
        Task<SiparisDetay> CreateSiparisDetay(SiparisDetayDto entity);
        Task<SiparisDetay> Update(SiparisDetayRequestDto entity);
        Task<SiparisDetay> GetSiparisDetay(int logref);
    }
}
