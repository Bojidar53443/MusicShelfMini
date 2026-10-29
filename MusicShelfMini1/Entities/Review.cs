using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShelfMini1.Entities
{
    public class Review
    {

        public int Id { get; set; }

        public string AuthorName { get; set; } = string.Empty;

        public int Rating { get; set; } 

        public string Content { get; set; } = string.Empty;

        public DateTime PostedOn { get; set; } = DateTime.Now;

        [ForeignKey(nameof(Song))]
        public int SongId { get; set; }
        public Song? Song { get; set; }
    }
}
