using Prizma.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared;

namespace Prizma.Core.Repositories
{
    public interface IFaturaRepository :  IRepository<Fatura>
    {
        Task<List<V047_Fatura>> LoadRecordsFromView(FaturaRequestDto request);
    }
}
