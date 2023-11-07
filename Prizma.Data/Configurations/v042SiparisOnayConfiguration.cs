using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared;

namespace Prizma.Data.Configurations
{
    internal class v042SiparisOnayConfiguration : IEntityTypeConfiguration<V042_SiparisOnay>
    {
        public void Configure(EntityTypeBuilder<V042_SiparisOnay> builder)
        {
            builder.HasNoKey().ToView("v042_siparis_onay");

            builder.Property(e => e.SiparisRef).HasColumnName("siparisref");

            builder.Property(e => e.OnaySira).HasColumnName("onaysira");

            builder.Property(e => e.OnayTipRef).HasColumnName("onaytipref");

            builder.Property(e => e.OnayTipIKodu).HasColumnName("onaytipikodu");

            builder.Property(e => e.OnayTipAdi).HasColumnName("onaytipadi");

            builder.Property(e => e.OnayRef).HasColumnName("onayref");

            builder.Property(e => e.OnayIKodu).HasColumnName("onayikodu");

            builder.Property(e => e.OnayAdi).HasColumnName("onayadi");

            builder.Property(e => e.OnayUser).HasColumnName("onayuser");

            builder.Property(e => e.OnayUserAdi).HasColumnName("onayuseradi");

            builder.Property(e => e.Onaylayan).HasColumnName("onaylayan");

            builder.Property(e => e.TopluOnay).HasColumnName("topluonay");

            builder.Property(e => e.Aciklama).HasColumnName("aciklama");

            builder.Property(e => e.Active).HasColumnName("active");

            builder.Property(e => e.status).HasColumnName("status");

            builder.Property(e => e.insdate)
                  .HasColumnType("datetime")
                  .HasColumnName("insdate");

            builder.Property(e => e.insuser)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("insuser");

            builder.Property(e => e.upddate)
                .HasColumnType("datetime")
                .HasColumnName("upddate");

            builder.Property(e => e.upduser)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("upduser");

            builder.Property(e => e.deluser)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("deluser");

            builder.Property(e => e.deldate)
                .HasColumnType("datetime")
                .HasColumnName("deldate");
        }
    }
}
