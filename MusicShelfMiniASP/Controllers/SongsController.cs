using Microsoft.AspNetCore.Mvc;
using MusicShelfMini1.Data;
using MusicShelfMini1.Entities;


namespace MusicShelfMiniASP.Controllers
{
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext context;

        public SongsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var songs = context.Songs.ToList();
            return View(songs);
        }

        public IActionResult Seed()
        {
            if (!context.Songs.Any())
            {
                var song = new Song
                {
                    Title = "Instant Crush"
                };

                context.Songs.Add(song);
                context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
