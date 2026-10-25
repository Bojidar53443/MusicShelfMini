using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShelfMini1.Entities
{
    public class Album
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Artist { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public int Year { get; set; }
        //нз господине какво искате да представлява това с песните и жанра жанр на песните или на самия албум или и на двете за сега ще го оставя така
        //public List<Song> Songs { get; set; } = new List<Song>();
        //public int SongsCount => Songs.Count;
        public int SongsCount { get; set; }
    }
}
