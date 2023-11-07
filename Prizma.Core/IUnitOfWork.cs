using Prizma.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ITalepDetayRepository TalepDetayRepository { get; }
        IMahalRepository MahalRepository { get; }
        ITalepFisRepository TalepFisRepository { get; }
        IProjeRepository ProjeRepository { get; }
        IAktiviteRepository AktiviteRepository { get; }
        ISiparisRepository SiparisRepository { get; }
        ISiparisDetayRepository SiparisDetayRepository { get; }
        ITalepOnayRepository TalepOnayRepository { get; }
        ITalepDosyaRepository TalepDosyaRepository { get; }
        IKaynakRepository KaynakRepository { get; }
        ISiparisOnayRepository SiparisOnayRepository { get; }
        ISiparisDosyaRepository SiparisDosyaRepository { get; }
        Task<int> CommitAsync();
    }
}
