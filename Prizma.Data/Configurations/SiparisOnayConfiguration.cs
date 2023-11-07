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
    public class SiparisOnayConfiguration : IEntityTypeConfiguration<SiparisOnay>
    {
        public void Configure(EntityTypeBuilder<SiparisOnay> builder)
        {
            builder.ToTable("siparis_onay");

            builder.HasKey(e => e.logref);
            builder.Property(e => e.logref)
                   .ValueGeneratedNever()
                   .HasColumnName("logref");

            builder.Property(e => e.SiparisRef).HasColumnName("siparisref");

            builder.Property(e => e.OnaySira).HasColumnName("onaysira");

            builder.Property(e => e.OnayTipRef).HasColumnName("onaytipref");

            builder.Property(e => e.OnayRef).HasColumnName("onayref");

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
