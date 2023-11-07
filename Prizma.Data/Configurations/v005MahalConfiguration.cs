using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaWebApp.Shared;
using UmotaWebApp.Shared.ScaffoldModels;

namespace Prizma.Data.Configurations
{
    public class v005MahalConfiguration : IEntityTypeConfiguration<V005Mahal>
    {
        public void Configure(EntityTypeBuilder<V005Mahal> builder)
        {
            builder.HasNoKey().ToView("v005_mahal");

            builder.Property(e => e.Logref).HasColumnName("logref");
            builder.Property(e => e.Projeref).HasColumnName("projeref");
            builder.Property(e => e.Adi).HasColumnName("adi");
            builder.Property(e => e.Turref).HasColumnName("turref");
            builder.Property(e => e.Projeadi).HasColumnName("projeadi");
            builder.Property(e => e.Turadi).HasColumnName("turadi");

            builder.Property(e => e.Active).HasColumnName("active");
            builder.Property(e => e.Status).HasColumnName("status");

            builder.Property(e => e.Insdate)
                 .HasColumnType("datetime")
                 .HasColumnName("insdate");

            builder.Property(e => e.Insuser)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("insuser")
                .UseCollation("SQL_Latin1_General_CP1254_CI_AS");


            builder.Property(e => e.Upddate)
                .HasColumnType("datetime")
                .HasColumnName("upddate");

            builder.Property(e => e.Upduser)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("upduser")
                .UseCollation("SQL_Latin1_General_CP1254_CI_AS");
        }
    }
}
