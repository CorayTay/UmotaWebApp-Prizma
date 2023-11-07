using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UmotaWebApp.Shared;

namespace Prizma.Data.Configurations
{
    public class v001AktiviteConfiguration : IEntityTypeConfiguration<V001Aktivite>
    {
        public void Configure(EntityTypeBuilder<V001Aktivite> builder)
        {
            builder.HasNoKey().ToView("v001_aktivite");

            builder.Property(x => x.Logref).HasColumnName("logref");
            builder.Property(x => x.Parlogref).HasColumnName("parlogref");
            builder.Property(x => x.Kodu).HasColumnName("kodu");
            builder.Property(x => x.Adi).HasColumnName("adi");
            builder.Property(x => x.Uzunadi).HasColumnName("uzunadi");
            builder.Property(x => x.Uzunkodu).HasColumnName("uzunkodu");

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
