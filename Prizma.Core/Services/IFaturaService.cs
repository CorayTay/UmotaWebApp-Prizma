using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared;

namespace Prizma.Core.Services
{
    public interface IFaturaService
    {
        Task<List<V047_Fatura>> LoadRecordsFromView(FaturaRequestDto request);
    }
}
