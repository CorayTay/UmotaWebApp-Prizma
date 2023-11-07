using Microsoft.EntityFrameworkCore;
using Prizma.Core.Model;
using Prizma.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Data.Repositories
{
    public class SiparisDosyaRepository : Repository<SiparisDosya>, ISiparisDosyaRepository
    {
        public SiparisDosyaRepository(DbContext context) : base(context)
        {
        }

        private PrizmaDbContext dbContext
        {
            get { return Context as PrizmaDbContext; }
        }

        public async Task<SiparisDosya> CreateSiparisDosya(SiparisDosya entity)
        {
            await dbContext.SiparisDosya.AddAsync(entity);

            return entity;
        }

        public async Task<List<SiparisDosya>> GetDosyalar(int siparisref)
        {
            return await dbContext.SiparisDosya.Where(x => x.SiparisLogRef == siparisref).ToListAsync();
        }
    }
}
