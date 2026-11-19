using System;
using System.Collections.Generic;
using System.Text;

namespace MusicShelfMini.Services
{
    public class SongListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int SongId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string AlbumTitle { get; set; } = string.Empty;
        public string SongWriterName { get; set; } = string.Empty;
        public int ReviewsCount { get; set; }
    }
}
    

