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
using UmotaWebApp.Shared.Enum;
using UmotaWebApp.Shared.ModelDto;

namespace Prizma.Data.Repositories
{
    public class FaturaRepository : Repository<Fatura>, IFaturaRepository
    {
        private PrizmaDbContext dbContext
        {
            get { return Context as PrizmaDbContext; }
        }

        public FaturaRepository(PrizmaDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<V047_Fatura>> LoadRecordsFromView(FaturaRequestDto request)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            string sql = "select";
            if (request.TopRowCount > 0)
            {
                sql += " top " + request.TopRowCount;
            }
            sql += " a.* from v047_fatura a with(nolock)";
            if (request.FaturaDto != null && request.FaturaDto.Logref != 0)
            {
                sql += " where a.logref = " + request.FaturaDto.Logref;
            }
            else
            {
                sql += " where 1 = 1";
                if (request.FisTip.HasValue && request.FisTip > 0)
                    sql += " and a.fistip = " + request.FisTip;
                if (request.BaslangicTarih.HasValue)
                {
                    sql += " and a.tarih >= @bastar";
                    parameters.Add(new SqlParameter("@bastar", request.BaslangicTarih));
                }
                if (request.BitisTarih.HasValue)
                {
                    sql += " and a.tarih <= @bittar";
                    parameters.Add(new SqlParameter("@bittar", request.BitisTarih));
                }
                if (request.DurumRef.HasValue && request.DurumRef > 0)
                    sql += " and a.durumref = " + request.DurumRef;
                if (request.ProjeRef.HasValue && request.ProjeRef > 0)
                    sql += " and a.projeref = " + request.ProjeRef;
                if (request.CariRef.HasValue && request.CariRef > 0)
                    sql += " and a.cariref = " + request.CariRef;
                if (!string.IsNullOrWhiteSpace(request.CariAdi))
                {
                    parameters.Add(new SqlParameter("@CariAdi", "%" + request.CariAdi + "%"));
                    sql += " and a.cariadi like @CariAdi";
                }
                if (!string.IsNullOrEmpty(request.DurumIKoduSecimList))
                    sql += " and a.durumikodu in (" + request.DurumIKoduSecimList + ")";
                if (request.OnayBekleyen == true)
                {
                    sql += " and exists ";
                    sql += " (select aa.logref from v049_fatura_onay aa with(nolock)";
                    sql += "  where aa.onayuser like '%" + request.kullanicikodu + ";%'";
                    sql += "  and aa.faturaref = a.logref";
                    sql += "  and aa.onayikodu = " + (int)SharedEnums.OnayDurumu.Bekliyor;
                    sql += "  and aa.active = 0 ";
                    sql += "  and not exists ";
                    sql += "  (select aaa.logref from v049_fatura_onay aaa with(nolock)";
                    sql += "   where aaa.faturaref = aa.faturaref";
                    sql += "   and aaa.onaysira < aa.onaysira";
                    sql += "   and aaa.active = 0";
                    sql += "   and aaa.onayikodu <> " + (int)SharedEnums.OnayDurumu.Onaylandi;
                    sql += "  )";
                    sql += "  and not exists ";
                    sql += "  (select aaa.logref from v049_fatura_onay aaa with(nolock)";
                    sql += "   where aaa.faturaref = aa.faturaref";
                    sql += "   and aaa.onaysira > aa.onaysira";
                    sql += "   and aaa.active = 0";
                    sql += "   and aaa.onayikodu <> " + (int)SharedEnums.OnayDurumu.Bekliyor;
                    sql += "  )";
                    sql += " )";
                }

                if (request.TumFaturalariGormeYetkisi == false)
                {
                    sql += " and (";
                    sql += " a.insuser like '" + request.kullanicikodu + "'";
                    sql += " or exists  ";
                    sql += "   (select aa.logref from v011_kullanici_detay_proje aa WITH(NOLOCK)";
                    sql += "    where aa.kullanici_kodu like '" + request.kullanicikodu + "'";
                    sql += "    and aa.projeref = a.projeref";
                    sql += "    and aa.active = 0 )";
                    sql += " )";
                }

                if (!string.IsNullOrWhiteSpace(request.SearchText))
                {
                    parameters.Add(new SqlParameter("@SearchText", "%" + request.SearchText + "%"));
                    sql += " and (";
                    sql += "    a.projeadi like @SearchText";
                    sql += " or a.cariadi like @SearchText";
                    sql += " or a.fisno like @SearchText";
                    sql += " or a.belgeno like @SearchText";
                    sql += " )";
                }

                if (!string.IsNullOrWhiteSpace(request.SearchTextSatir))
                {
                    parameters.Add(new SqlParameter("@SearchTextSatir", "%" + request.SearchTextSatir + "%"));
                    sql += " and exists ( select aa.logref from v048_fatura_detay aa with(nolock) where aa.parlogref = a.logref";
                    sql += " and ( aa.aciklama like @SearchTextSatir";
                    sql += " or aa.kaynakadi like @SearchTextSatir";
                    sql += " or aa.aktivite3adi like @SearchTextSatir";
                    sql += " ))";
                }

                if (!string.IsNullOrWhiteSpace(request.SQLStringOrderBy))
                {
                    sql += " order by " + request.SQLStringOrderBy;
                }
            }

            var result = dbContext.v047_Fatura.FromSqlRaw(sql, parameters.ToArray());
            return await result.ToListAsync();
        }
    }
}
