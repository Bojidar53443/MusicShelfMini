using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShelfMini1.Entities
{
    public class SongWriter
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Song> Songs { get; set; } = new List<Song>();
    }
}
