using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;


namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            string filmBaslik = "film basligi";
            string filmAciklama = "film aciklama";
            string filmYonetmen = "film yonetmen";
            string[] oyuncular = { "oyuncu 1", "oyuncu 2", "oyuncu 3", "oyuncu 4" };

            var m = new Movie();

            m.Title = filmBaslik;
            m.Description = filmAciklama;
            m.Director = filmYonetmen;
            m.Players = oyuncular;

            return View(m);

        }

        public IActionResult About()
        {
            return View();
        }
    }
}
