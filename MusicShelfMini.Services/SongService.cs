using Microsoft.EntityFrameworkCore;
using MusicShelfMini1.Data;

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
    }
}