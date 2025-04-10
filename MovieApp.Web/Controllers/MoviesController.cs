using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var filmListesi = new List<Movie>()
            {
                new Movie {Title="film 1",Description="açıklama 1",Director="yonetmen 1",Players=new string[]{"player 1","player 2","player 3"},ImageUrl="fightclub.jpg"},
                new Movie {Title="film 2",Description="açıklama 2",Director="yonetmen 2",Players=new string[]{"player 1","player 2","player 3"},ImageUrl ="godfather.jpg"},
                new Movie {Title="film 3",Description="açıklama 3",Director="yonetmen 3",Players=new string[]{"player 1","player 2","player 3"},ImageUrl ="interstaller.jpg"}
            };  
            return View("Movies",filmListesi);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
