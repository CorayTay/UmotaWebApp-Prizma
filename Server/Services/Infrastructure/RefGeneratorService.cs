using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using UmotaWebApp.Server.Data.Models;
using Dapper;
using UmotaWebApp.Shared.ModelDto;
using UmotaWebApp.Server.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using UmotaWebApp.Shared;

namespace UmotaWebApp.Server.Services.Infrastructure
{
    public class RefGeneratorService : IRefGenerator
    {
        public IConfiguration Configuration { get; }

        public RefGeneratorService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<string> GenerateRowRef(string table, string keyField, string firmaId)
        {
            if (string.IsNullOrEmpty(firmaId))
                throw new Exception("Firma Dönem seçimi yapınız");

            using (SqlConnection db = new SqlConnection(Configuration.GetPrizmeDbConnection()))
            {
                var result = await db.QueryFirstAsync<string>("select dbo.GenerateNewCode(isnull((select max(" +
                                    keyField
                                    + ") from " + table + "),'00000')) as value"
                                    , commandType: CommandType.Text);
                return result;
            }


        }

        public async Task<int> RefNoAl(string tablename, string firmaId)
        {

            if (string.IsNullOrEmpty(firmaId))
                throw new Exception("Firma Dönem seçimi yapınız");

            using (SqlConnection db = new SqlConnection(Configuration.GetPrizmeDbConnection()))
            {
                var p = new DynamicParameters();
                p.Add("@tablename", tablename);
                p.Add("@ReturnValue", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                await db.ExecuteAsync("RefNoAl", p, commandType: CommandType.StoredProcedure);

                int c = p.Get<int>("@ReturnValue");

                return c;

            }

        }
        public async Task<IEnumerable<OdemePlaniDto>> GetOdemePlaniList(int logofirmno)
        {
            using (SqlConnection db = new SqlConnection(Configuration.GetUmotaConnectionString(null)))
            {

                string LogoDbName = Configuration["LogoDbName"];
                string LogoFirmaNo = logofirmno.ToString("000");
                string sqlstring = "SELECT  LOGICALREF,  CODE,  DEFINITION_ from " + LogoDbName + ".[dbo].[LG_" + LogoFirmaNo + "_PAYPLANS] with(nolock) where ACTIVE=0";

                IEnumerable<OdemePlaniDto> dbResponse;
                dbResponse = await db.QueryAsync<OdemePlaniDto>(sqlstring, commandType: CommandType.Text);
                return dbResponse;
            }


        }
        public async Task<IEnumerable<SisSabitlerDetayDto>> GetSabitDetayList(int tip)
        {
            using (SqlConnection db = new SqlConnection(Configuration.GetUmotaConnectionString(null)))
            {
                string sqlstring = string.Format("SELECT [sabit_detay_id] as SabitDetayId,[tip],[kodu],[ikodu],[adi],[yabanci_adi],[siralama],[ozel_kod1],[ozel_kod2],[ozel_kod3],[ozel_kod4],[ozel_kod5],[ozel_kod6],[ozel_kod7],[ozel_kod8],[ozel_kod9],[ozel_kod10],[ozel_kod11],[ozel_kod12],[izin],[renk1],[renk2] FROM [dbo].[sis_sabitler_detay] where tip = {0}", tip);
                IEnumerable<SisSabitlerDetayDto> dbResponse;
                dbResponse = await db.QueryAsync<SisSabitlerDetayDto>(sqlstring, commandType: CommandType.Text);
                return dbResponse;
            }


        }
        public async Task<IEnumerable<SpeCodesDto>> GetCariSektorList(int logofirmno)
        {
            using (SqlConnection db = new SqlConnection(Configuration.GetUmotaConnectionString(null)))
            {
                string LogoDbName = Configuration["LogoDbName"];
                string LogoFirmaNo = logofirmno.ToString("000");
                string sqlstring = "SELECT  LOGICALREF,  SPECODE,  DEFINITION_ from " + LogoDbName + ".[dbo].[LG_" + LogoFirmaNo + "_SPECODES] with(nolock) where CODETYPE = 1 AND SPECODETYPE = 26 AND SPETYP3 = 1";

                IEnumerable<SpeCodesDto> dbResponse;
                dbResponse = await db.QueryAsync<SpeCodesDto>(sqlstring, commandType: CommandType.Text);
                return dbResponse;
            }
        }
        public async Task<string> FisNoAlLogo(string table, string keyField, int firmaId, int logofirmaId)
        {
            if (firmaId < 1)
                throw new Exception("Firma Dönem seçimi yapınız");

            using (SqlConnection db = new SqlConnection(Configuration.GetUmotaConnectionString(firmaId.ToString())))
            {
                string LogoDbName = Configuration["LogoDbName"];
                string LogoFirmaNo = logofirmaId.ToString("000");
                string tblName = LogoDbName + ".[dbo].[LG_" + LogoFirmaNo + "_" + table + "]";

                var result = await db.QueryFirstAsync<string>("select dbo.GenerateNewCode(isnull((select max(" +
                                    keyField
                                    + ") from " + tblName + "),'00000')) as value"
                                    , commandType: CommandType.Text);
                return result;
            }


        }
        public async Task<IEnumerable<string>> GetTeslimSekliList()
        {
            using (SqlConnection db = new SqlConnection(Configuration.GetUmotaConnectionString(null)))
            {
                string LogoDbName = Configuration["LogoDbName"];
                string sqlstring = "SELECT SDEF from " + LogoDbName + ".[dbo].L_SHPTYPES with(nolock) order by SDEF";

                IEnumerable<string> dbResponse;
                dbResponse = await db.QueryAsync<string>(sqlstring, commandType: CommandType.Text);
                return dbResponse;
            }
        }

        public async Task<IEnumerable<V002_Kaynak>> GetKaynakList(int aktivite3LogRef)
        {
            using (SqlConnection db = new SqlConnection(Configuration.GetPrizmeDbConnection()))
            {
                string sqlstring = "select logref,adi,aktiviteref,aktiviteref2,aktiviteref3,aktiviteadi from [dbo].[v002_kaynak] with(nolock) where [active] = 0";
                if (aktivite3LogRef != null && aktivite3LogRef > 0)
                    sqlstring += string.Format(" and aktiviteref = {0}", aktivite3LogRef);
                IEnumerable<V002_Kaynak> dbResponse;
                dbResponse = await db.QueryAsync<V002_Kaynak>(sqlstring, commandType: CommandType.Text);
                return dbResponse;
            }
        }

        public async Task<IEnumerable<SisSabitlerDetayDto>> GetKaynakBirimKoduList(int kaynakLogRef)
        {
            using (SqlConnection db = new SqlConnection(Configuration.GetPrizmeDbConnection()))
            {
                string sqlstring = string.Format(@"select b.sabit_detay_id as SabitDetayId,b.kodu as Kodu from kaynak_birim a with(nolock) inner join UmoYAPI..sis_sabitler_detay b with(nolock) on a.birimref = b.sabit_detay_id where a.parlogref = {0} order by b.kodu", kaynakLogRef);

                IEnumerable<SisSabitlerDetayDto> dbResponse;
                dbResponse = await db.QueryAsync<SisSabitlerDetayDto>(sqlstring, commandType: CommandType.Text);
                return dbResponse;
            }
        }

        public async Task<string> GetMaxTalepFisNo(string projekodu, string talepturkodu)
        {
            using (SqlConnection db = new SqlConnection(Configuration.GetPrizmeDbConnection()))
            {
                string sqlstring = "select dbo.GenerateNewCode (isnull((select max(fisno) num from v030_talep_fis with(nolock) where projekodu='"+projekodu+"' and turkodu = '"+talepturkodu+"'),'"+projekodu.Substring(0,3)+"-"+talepturkodu.Substring(0,2)+"-000000') ) as num";
           
                var dbResponse = await db.QuerySingleAsync<string>(sqlstring, commandType: CommandType.Text);
                return dbResponse;
            }
        }
        public async Task<string> GetParamVal(string kodu)
        {
            using (SqlConnection db = new SqlConnection(Configuration.GetPrizmeDbConnection()))
            {
                string sqlstring = "select isnull((select top 1 deger from parametre with(nolock) where kodu=" + kodu + "),'') as deger";

                var dbResponse = await db.QuerySingleAsync<string>(sqlstring, commandType: CommandType.Text);
                return dbResponse;
            }
        }
    }
}
