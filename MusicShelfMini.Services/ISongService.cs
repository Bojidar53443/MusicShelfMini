using MusicShelfMini1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MusicShelfMini.Services;

namespace MusicShelfMini.Services
{
    public interface ISongService
    {
        Task<List<SongListDto>> GetAllAsync();
        Task SeedAsync();
        Task<List<SelectOptionDto>> GetAlbumOptionsAsync();
        Task<List<SelectOptionDto>> GetSongWriterOptionsAsync();
        Task CreateAsync(string title, int? albumId, int? songWriterId);
    }
}
