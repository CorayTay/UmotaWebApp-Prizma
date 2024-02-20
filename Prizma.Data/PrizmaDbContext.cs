using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Prizma.Core.Model;
using Prizma.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared;

namespace Prizma.Data
{
    public class PrizmaDbContext : DbContext
    {
        public DbSet<TalepDetay> TalepDetays { get; set; }
        public DbSet<Mahal> Mahals { get; set; }
        public DbSet<TalepFis> TalepFis { get; set; }
        public DbSet<Proje> Proje { get; set; }
        public DbSet<V030_TalepFis> v030_TalepFis { get; set; }
        public DbSet<V031_TalepDetay> v031_TalepFisDetay { get; set; }
        public DbSet<TalepOnay> TalepOnaay { get; set; }
        public DbSet<V032_TalepOnay> v032_TalepOnay { get; set; }
        public DbSet<V001Aktivite> v001Aktivite { get; set; }
        public DbSet<V005Mahal> v005Mahal { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<V040_Siparis> v040_Siparis { get; set; }
        public DbSet<V041_SiparisDetay> v041_SiparisDetay { get; set; }
        public DbSet<TalepDosya> TalepDosya { get; set; }
        public DbSet<Kaynak> Kaynak { get; set; }
        public DbSet<V002_Kaynak> v002_Kaynak { get; set; }
        public DbSet<SiparisOnay> SiparisOnay { get; set; }
        public DbSet<V042_SiparisOnay> v042_SiparisOnay { get; set; }
        public DbSet<SiparisDosya> SiparisDosya { get; set; }
        public DbSet<SiparisDetay> SiparisDetay { get; set; }
        public DbSet<V047_Fatura> v047_Fatura { get; set; }
        public DbSet<Fatura> Fatura { get; set; }

        public PrizmaDbContext(DbContextOptions<PrizmaDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TalepDetayConfiguration());
            modelBuilder.ApplyConfiguration(new MahalConfiguration());
            modelBuilder.ApplyConfiguration(new TalepFisConfiguration());
            modelBuilder.ApplyConfiguration(new ProjeConfiguration());
            modelBuilder.ApplyConfiguration(new v030TalepFisConfiguration());
            modelBuilder.ApplyConfiguration(new v040SiparisConfiguration());
            modelBuilder.ApplyConfiguration(new V041SiparisDetayConfiguration());
            modelBuilder.ApplyConfiguration(new v031TalepFisDetayConfiguration());
            modelBuilder.ApplyConfiguration(new v001AktiviteConfiguration());
            modelBuilder.ApplyConfiguration(new v005MahalConfiguration());
            modelBuilder.ApplyConfiguration(new TalepOnayConfiguration());
            modelBuilder.ApplyConfiguration(new v032TalepOnayConfiguration());
            modelBuilder.ApplyConfiguration(new KaynakConfiguration());
            modelBuilder.ApplyConfiguration(new V002KaynakConfiguration());
            modelBuilder.ApplyConfiguration(new TalepDosyaConfiguration());
            modelBuilder.ApplyConfiguration(new SiparisConfiguration());
            modelBuilder.ApplyConfiguration(new SiparisOnayConfiguration());
            modelBuilder.ApplyConfiguration(new v042SiparisOnayConfiguration());
            modelBuilder.ApplyConfiguration(new SiparisDosyaConfiguration());
            modelBuilder.ApplyConfiguration(new SiparisDetayConfiguration());
            modelBuilder.ApplyConfiguration(new FaturaConfiguration());
            modelBuilder.ApplyConfiguration(new V047FaturaConfiguration());
        }
    }
}
