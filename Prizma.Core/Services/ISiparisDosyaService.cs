using Prizma.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto;

namespace Prizma.Core.Services
{
    public interface ISiparisDosyaService
    {
        Task<SiparisDosya> CreateSiparisDosya(SiparisDosyaDto siparisDosya);
        Task<List<SiparisDosya>> GetDosyalar(int siparisref);
    }
}
