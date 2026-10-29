using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicShelfMini1.Data;
using MusicShelfMini1.Entities;


namespace MusicShelfMini1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<RecordLabel> recordLabels { get; set; }
        public DbSet<SongWriter> SongWriters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Song>()
            .HasOne(s => s.SongWriter)
            .WithMany(w => w.Songs)
            .HasForeignKey(s => s.SongWriterId)
            .OnDelete(DeleteBehavior.SetNull);

   

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Song)
                .WithMany(s => s.Reviews) 
                .HasForeignKey(r => r.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Song>()
                .HasOne(s => s.Album)
                .WithMany(a => a.Songs)
                .HasForeignKey(s => s.AlbumId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
