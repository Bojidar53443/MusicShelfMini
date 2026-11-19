using Microsoft.AspNetCore.Mvc;
using MusicShelfMini.Services;
using MusicShelfMiniASP.ViewModels.Songs;

namespace MusicShelfMiniASP.Controllers
{
    public class SongsController : Controller
    {
        private readonly ISongService songService;

        public SongsController(ISongService songService)
        {
            this.songService = songService;
        }

        public async Task<IActionResult> Index()
        {
            var songs = await songService.GetAllAsync();

            var viewModel = new SongsIndexViewModel
            {
                Songs = songs
            };

            return View(viewModel);
        }
    }
}