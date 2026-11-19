using Microsoft.EntityFrameworkCore;
using MusicShelfMini1.Data;
using MusicShelfMini1.Entities;

namespace MusicShelfMini.Services
{
    public class SongService : ISongService
    {
        private readonly ApplicationDbContext context;

        public SongService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<SongListDto>> GetAllAsync()
        {
            return await context.Songs
                .Select(s => new SongListDto
                {
                    SongId = s.Id,
                    Title = s.Title,
                    AlbumTitle = s.Album != null ? s.Album.Title : "Без албум",
                    SongWriterName = s.SongWriter != null ? s.SongWriter.Name : "Неизвестен",
                    ReviewsCount = s.Reviews.Count
                })
                .ToListAsync();
        }

        public async Task SeedAsync()
        {
            if (!await context.Songs.AnyAsync())
            {
                context.Songs.Add(new Song { Title = "Instant Crush" });
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<SelectOptionDto>> GetAlbumOptionsAsync()
        {
            return await context.Albums
                .Select(a => new SelectOptionDto
                {
                    Id = a.Id,
                    Name = a.Title
                })
                .ToListAsync();
        }

        public async Task<List<SelectOptionDto>> GetSongWriterOptionsAsync()
        {
            return await context.SongWriters
                .Select(w => new SelectOptionDto
                {
                    Id = w.Id,
                    Name = w.Name
                })
                .ToListAsync();
        }

        public async Task CreateAsync(string title, int? albumId, int? songWriterId)
        {
            var song = new Song
            {
                Title = title,
                AlbumId = albumId,
                SongWriterId = songWriterId
            };

            context.Songs.Add(song);
            await context.SaveChangesAsync();
        }
    }
}