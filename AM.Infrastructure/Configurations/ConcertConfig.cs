using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class ConcertConfig : IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            builder.HasOne(p => p.Festival).WithMany(p => p.Concerts).HasForeignKey(p => p.FestivalFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Artiste).WithMany(p => p.Concerts).HasForeignKey(p => p.ArtisteFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasKey(p => new { p.FestivalFk, p.ArtisteFk, p.DateConcert });
        }
    }
}
