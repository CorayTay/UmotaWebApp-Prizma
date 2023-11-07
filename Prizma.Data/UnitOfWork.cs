using Prizma.Core;
using Prizma.Core.Repositories;
using Prizma.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Data
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly PrizmaDbContext _context;
        private TalepDetayRepository _talepdetayRepository;
        private MahalRepository _mahalRepository;
        private ITalepFisRepository _talepfRepository;
        private IProjeRepository _projeRepository;
        private IAktiviteRepository _aktiviteRepository;

        private ISiparisRepository _siparisRepository;
        private ISiparisDetayRepository _siparisDetayRepository;
        private ITalepOnayRepository _taleponayRepository;
        private IKaynakRepository _kaynakRepository;
        private ITalepDosyaRepository _talepdosyaRepository;
        private ISiparisOnayRepository _siparisonayRepository;
        private ISiparisDosyaRepository _siparisdosyaRepository;

        public UnitOfWork(PrizmaDbContext context)
        {
            _context = context;
        }

        public ITalepDetayRepository TalepDetayRepository => _talepdetayRepository = _talepdetayRepository ?? new TalepDetayRepository(_context);
        public IMahalRepository MahalRepository => _mahalRepository = _mahalRepository ?? new MahalRepository(_context);
        public ITalepFisRepository TalepFisRepository => _talepfRepository = _talepfRepository ?? new TalepFisRepository(_context);
        public IProjeRepository ProjeRepository => _projeRepository = _projeRepository ?? new ProjeRepository(_context);
        public IAktiviteRepository AktiviteRepository => _aktiviteRepository = _aktiviteRepository ?? new AktiviteRepository(_context);
        public ISiparisRepository SiparisRepository => _siparisRepository = _siparisRepository ?? new SiparisRepository(_context);
        public ISiparisDetayRepository SiparisDetayRepository => _siparisDetayRepository = _siparisDetayRepository ?? new SiparisDetayRepository(_context);
        public ITalepOnayRepository TalepOnayRepository => _taleponayRepository = _taleponayRepository ?? new TalepOnayRepository(_context);
        public IKaynakRepository KaynakRepository => _kaynakRepository = _kaynakRepository ?? new KaynakRepository(_context);
        public ITalepDosyaRepository TalepDosyaRepository => _talepdosyaRepository = _talepdosyaRepository ?? new TalepDosyaRepository(_context);
        public ISiparisOnayRepository SiparisOnayRepository => _siparisonayRepository = _siparisonayRepository ?? new SiparisOnayRepository(_context);
        public ISiparisDosyaRepository SiparisDosyaRepository => _siparisdosyaRepository = _siparisdosyaRepository ?? new SiparisDosyaRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
