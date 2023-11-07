using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto.Request;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared;

namespace Prizma.Core.Services
{
    public interface ISiparisOnayService
    {
        Task<IEnumerable<V042_SiparisOnay>> GetSiparisFisOnayListAsnyc(SiparisOnayRequestDto request);
        Task<int> SiparisOnayRota(SiparisOnayRequestDto request);
        Task<int> SiparisDurumGuncelle(SiparisOnayRequestDto request);
        Task<int> SiparisGetOnayLineRef(SiparisOnayRequestDto request);
        Task<int> SiparisOnayla(SiparisOnayRequestDto request);
        Task<bool> UploadSiparisDosya(SiparisDosyaRequestDto request);
    }
}
