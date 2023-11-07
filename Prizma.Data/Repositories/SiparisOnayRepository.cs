using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Prizma.Core.Model;
using Prizma.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ModelDto.Request;

namespace Prizma.Data.Repositories
{
    public class SiparisOnayRepository : Repository<SiparisOnay>, ISiparisOnayRepository
    {
        private PrizmaDbContext dbContext
        {
            get { return Context as PrizmaDbContext; }
        }
        public SiparisOnayRepository(DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<V042_SiparisOnay>> GetSiparisFisOnayListAsnyc(SiparisOnayRequestDto request)
        {
            var qry = dbContext.v042_SiparisOnay.AsQueryable();

            qry = qry.Where(x => x.SiparisRef == request.SiparisRef);

            return await qry.Take(100).ToListAsync();
        }

        public Task<int> SiparisDurumGuncelle(SiparisOnayRequestDto request)
        {
            FormattableString sql = $"[dbo].[UmotaSP_SiparisDurumGuncelle] @SiparisRef = {request.SiparisRef},@KullaniciKodu = {request.kullanicikodu}";
            var result = dbContext.Database.ExecuteSql(sql);

            return Task.FromResult(result);
        }

        public Task<int> SiparisGetOnayLineRef(SiparisOnayRequestDto request)
        {
            var parameterReturn = new SqlParameter
            {
                ParameterName = "ReturnValue",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output,
            };

            string sql = $"EXEC @returnValue = [dbo].[UmotaSP_SiparisGetOnayLineRef] @SiparisRef = {request.SiparisRef},@KullaniciKodu = {request.kullanicikodu}";
            var result = dbContext.Database.ExecuteSqlRaw(sql, parameterReturn);
            int returnValue = (int)parameterReturn.Value;
            return Task.FromResult(returnValue);
        }

        public Task<int> SiparisOnayla(SiparisOnayRequestDto request)
        {
            FormattableString sql = $"[dbo].[UmotaSP_SiparisOnayla] @SiparisRef = {request.SiparisRef},@KullaniciKodu = {request.kullanicikodu},@OnayLineRef = {request.OnayLineRef},@OnayIKodu = {request.OnayDurumu},@Aciklama = {request.Aciklama}";
            var result = dbContext.Database.ExecuteSql(sql);

            return Task.FromResult(result);
        }

        public Task<int> SiparisOnayRota(SiparisOnayRequestDto request)
        {
            FormattableString sql = $"[dbo].[UmotaSP_SiparisOnayRotaProc] @SiparisRef = {request.SiparisRef},@KullaniciKodu = {request.kullanicikodu}";
            var result = dbContext.Database.ExecuteSql(sql);

            return Task.FromResult(result);
        }
    }
}
