using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prizma.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizma.Data.Configurations
{
    public class FaturaConfiguration : IEntityTypeConfiguration<Fatura>
    {
        public void Configure(EntityTypeBuilder<Fatura> builder)
        {
            builder.ToTable("fatura");

            builder.HasKey(e => e.logref);
            builder.Property(e => e.logref)
                   .ValueGeneratedNever()
                   .HasColumnName("logref");

            builder.Property(t => t.Fistip).HasColumnName("fistip");
            builder.Property(t => t.Fisno).HasColumnName("fisno");
            builder.Property(t => t.Tarih).HasColumnName("tarih");
            builder.Property(t => t.Saat).HasColumnName("saat");
            builder.Property(t => t.Belgeno).HasColumnName("belgeno");
            builder.Property(t => t.Cariref).HasColumnName("cariref");
            builder.Property(t => t.Projeref).HasColumnName("projeref");
            builder.Property(t => t.Ambarno).HasColumnName("ambarno");
            builder.Property(t => t.Ambaradi).HasColumnName("ambaradi");
            builder.Property(t => t.Durumref).HasColumnName("durumref");
            builder.Property(t => t.DovizrefRd).HasColumnName("dovizref_rd");
            builder.Property(t => t.DovizkuruRd).HasColumnName("dovizkuru_rd");
            builder.Property(t => t.NettoplamRd).HasColumnName("nettoplam_rd");
            builder.Property(t => t.DovizrefId).HasColumnName("dovizref_id");
            builder.Property(t => t.DovizkurturId).HasColumnName("dovizkurtur_id");
            builder.Property(t => t.DovizkuruId).HasColumnName("dovizkuru_id");
            builder.Property(t => t.NettoplamId).HasColumnName("nettoplam_id");
            builder.Property(t => t.NettoplamTl).HasColumnName("nettoplam_tl");
            builder.Property(t => t.Lgfirmano).HasColumnName("lgfirmano");
            builder.Property(t => t.Dosyaeki).HasColumnName("dosyaeki");
            builder.Property(t => t.Aciklama).HasColumnName("aciklama");
            builder.Property(t => t.Aciklama2).HasColumnName("aciklama2");
            builder.Property(t => t.Lgfatref).HasColumnName("lgfatref");
            builder.Property(t => t.Lgfatno).HasColumnName("lgfatno");
            builder.Property(t => t.Efatura).HasColumnName("efatura");
            builder.Property(t => t.Fiyatfarki).HasColumnName("fiyatfarki");
            builder.Property(t => t.Miktarfarki).HasColumnName("miktarfarki");
            builder.Property(t => t.Lgaktarildi).HasColumnName("lgaktarildi");
            builder.Property(t => t.Seri).HasColumnName("seri");
            builder.Property(t => t.PlanlamaKontrol).HasColumnName("planlama_kontrol");
            builder.Property(t => t.NettoplamSozlesmeId).HasColumnName("nettoplam_sozlesme_id");
            builder.Property(t => t.NettoplamSozlesmeTl).HasColumnName("nettoplam_sozlesme_tl");
            builder.Property(t => t.NettoplamSiparisId).HasColumnName("nettoplam_siparis_id");
            builder.Property(t => t.NettoplamSiparisTl).HasColumnName("nettoplam_siparis_tl");
            builder.Property(t => t.NettoplamDigerId).HasColumnName("nettoplam_diger_id");
            builder.Property(t => t.NettoplamDigerTl).HasColumnName("nettoplam_diger_tl");
            builder.Property(t => t.LgfatrefFf).HasColumnName("lgfatref_ff");
            builder.Property(t => t.LgfatnoFf).HasColumnName("lgfatno_ff");
            builder.Property(t => t.LgfatrefMf).HasColumnName("lgfatref_mf");
            builder.Property(t => t.LgfatnoMf).HasColumnName("lgfatno_mf");
            builder.Property(t => t.LgfatrefAna).HasColumnName("lgfatref_ana");
            builder.Property(t => t.LgfatnoAna).HasColumnName("lgfatno_ana");
            builder.Property(t => t.FiyatFarkiTipi).HasColumnName("fiyat_farki_tipi");
            builder.Property(t => t.Anafatref).HasColumnName("anafatref");
            builder.Property(t => t.Vadegun).HasColumnName("vadegun");
            builder.Property(t => t.Lgaktarilmasin).HasColumnName("lgaktarilmasin");
            builder.Property(t => t.KasadanOdendi).HasColumnName("kasadan_odendi");
            builder.Property(t => t.Odemeplankodu).HasColumnName("odemeplankodu");

            builder.Property(t => t.status).HasColumnName("status");
            builder.Property(e => e.insdate)
              .HasColumnType("datetime")
              .HasColumnName("insdate");

            builder.Property(e => e.insuser)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("insuser")
                .UseCollation("SQL_Latin1_General_CP1254_CI_AS");

            builder.Property(e => e.upddate)
                .HasColumnType("datetime")
                .HasColumnName("upddate");

            builder.Property(e => e.upduser)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("upduser")
                .UseCollation("SQL_Latin1_General_CP1254_CI_AS");
        }
    }
}
