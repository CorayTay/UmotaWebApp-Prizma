using Prizma.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Core.Repositories
{
    public interface ISiparisDosyaRepository : IRepository<SiparisDosya>
    {
        Task<SiparisDosya> CreateSiparisDosya(SiparisDosya entity);
        Task<List<SiparisDosya>> GetDosyalar(int siparisref);
    }
}
