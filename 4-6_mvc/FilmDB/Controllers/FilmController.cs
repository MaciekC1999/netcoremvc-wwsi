using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;


namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            var manager = new FilmManager();
            //var film = new FilmModel();
            //film.ID = 3;
            //film.Title = "Jaś i Małgosia 2";
            //film.Year = 1958;
            //manager.AddFilm(film);
            //manager.RemoveFilm(2);
            //manager.UpdateFilm(film);
            //manager.ChangeTitle(3, null);
            //var film = manager.GetFilm(3);
            //var films = manager.GetFilms();
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(FilmModel film)
        {
            var filmManager = new FilmManager();
            filmManager.AddFilm(film);
            return RedirectToAction("Index");
        }
    }
}
