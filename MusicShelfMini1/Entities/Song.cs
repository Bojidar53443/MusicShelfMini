using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShelfMini1.Entities
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int? AlbumId { get; set; } 
        public Album? Album { get; set; }

        public int? SongWriterId { get; set; }
        public SongWriter? SongWriter { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
