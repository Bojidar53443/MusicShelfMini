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
    }
}
