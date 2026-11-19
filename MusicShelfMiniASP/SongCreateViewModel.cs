using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MusicShelfMiniASP
{
    public class SongCreateViewModel
    {
        [Required(ErrorMessage = "Заглавието е задължително.")]
        public string Title { get; set; } = string.Empty;

        public int? AlbumId { get; set; }
        public int? SongWriterId { get; set; }

        public List<SelectListItem> Albums { get; set; } = new();
        public List<SelectListItem> SongWriters { get; set; } = new();
    }
}