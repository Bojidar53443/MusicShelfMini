using MusicShelfMini1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShelfMini.Services
{
    public interface ISongService
    {
        List<Song> GetAll();
    }
}
