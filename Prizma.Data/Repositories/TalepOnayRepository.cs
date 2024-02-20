using Azure.Core;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Prizma.Core.Model;
using Prizma.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Shared.ModelDto.Request;

namespace Prizma.Data.Repositories
{
    public class TalepOnayRepository : Repository<TalepOnay>, ITalepOnayRepository
    {
        private PrizmaDbContext dbContext
        {
            get { return Context as PrizmaDbContext; }
        }

        public TalepOnayRepository(PrizmaDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<V032_TalepOnay>> GetTalepFisOnayListAsnyc(TalepOnayRequestDto request)
        {
            var qry = dbContext.v032_TalepOnay.AsQueryable();

            qry = qry.Where(x => x.TalepRef == request.TalepRef);

            return await qry.Take(100).ToListAsync();
        }

        public Task<int> TalepOnayRota(TalepOnayRequestDto request)
        {
            FormattableString sql = $"[dbo].[UmotaSP_TalepOnayRotaProc] @TalepRef = {request.TalepRef},@KullaniciKodu = N'{request.kullanicikodu}'";
            var result = dbContext.Database.ExecuteSql(sql);

            return Task.FromResult(result);
        }

        public Task<int> TalepDurumGuncelle(TalepOnayRequestDto request)
        {
            FormattableString sql = $"[dbo].[UmotaSP_TalepDurumGuncelle] @TalepRef = {request.TalepRef},@KullaniciKodu = N' {request.kullanicikodu} '";
            var result = dbContext.Database.ExecuteSql(sql);

            return Task.FromResult(result);
        }
        public Task<int> TalepGetOnayLineRef(TalepOnayRequestDto request)
        {
            var parameterReturn = new SqlParameter
            {
                ParameterName = "ReturnValue",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output,
            };

            string sql = $"EXEC @returnValue = [dbo].[UmotaSP_TalepGetOnayLineRef] @TalepRef = {request.TalepRef},@KullaniciKodu = N' {request.kullanicikodu} '";
            var result = dbContext.Database.ExecuteSqlRaw(sql, parameterReturn);
            int returnValue = (int)parameterReturn.Value;
            return Task.FromResult(returnValue);

            //FormattableString sql = $"[dbo].[UmotaSP_TalepGetOnayLineRef] @TalepRef = {request.TalepRef},@KullaniciKodu = {request.kullanicikodu}";
            //var result = dbContext.Database.ExecuteSql(sql);

            //return Task.FromResult(result);
        }
        public Task<int> TalepOnayla(TalepOnayRequestDto request)
        {
            FormattableString sql = $"[dbo].[UmotaSP_TalepOnayla] @TalepRef = {request.TalepRef},@KullaniciKodu = N'{request.kullanicikodu}',@OnayLineRef = {request.OnayLineRef},@OnayIKodu = {request.OnayDurumu},@Aciklama = N'{request.Aciklama}'";
            var result = dbContext.Database.ExecuteSql(sql);

            return Task.FromResult(result);
        }
    }
}
