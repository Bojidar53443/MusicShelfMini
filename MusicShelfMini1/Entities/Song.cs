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

        public string Artist { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public int Year { get; set; }

        public int AlbumId { get; set; }

        public Album? Album { get; set; }
    }
}
