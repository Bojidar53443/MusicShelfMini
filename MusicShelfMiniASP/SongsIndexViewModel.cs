using MusicShelfMini.Services;

namespace MusicShelfMiniASP.ViewModels.Songs
{
    public class SongsIndexViewModel
    {
        public List<SongListDto> Songs { get; set; } = new List<SongListDto>();
    }
}