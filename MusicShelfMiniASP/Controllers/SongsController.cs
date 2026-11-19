using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicShelfMini.Services;
using MusicShelfMiniASP;
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

            ViewBag.Conn = HttpContext.RequestServices
                .GetRequiredService<IConfiguration>()
                .GetConnectionString("DefaultConnection");

            return View(viewModel);
        }

        public async Task<IActionResult> Seed()
        {
            await songService.SeedAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var albums = await songService.GetAlbumOptionsAsync();
            var writers = await songService.GetSongWriterOptionsAsync();

            var model = new SongCreateViewModel
            {
                Albums = albums.Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name
                }).ToList(),
                SongWriters = writers.Select(w => new SelectListItem
                {
                    Value = w.Id.ToString(),
                    Text = w.Name
                }).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SongCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var albums = await songService.GetAlbumOptionsAsync();
                var writers = await songService.GetSongWriterOptionsAsync();

                model.Albums = albums.Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Name
                }).ToList();

                model.SongWriters = writers.Select(w => new SelectListItem
                {
                    Value = w.Id.ToString(),
                    Text = w.Name
                }).ToList();

                return View(model);
            }

            await songService.CreateAsync(model.Title.Trim(), model.AlbumId, model.SongWriterId);
            return RedirectToAction(nameof(Index));
        }
    }
}