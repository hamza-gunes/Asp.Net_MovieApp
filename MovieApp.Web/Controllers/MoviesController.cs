using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {

        public string Index()
        {
            return "Film index";
        }

        public string List()
        {
            return "Film listesi";
        }

        public string Details()
        {
            return "Film detay";
        }
    }
}
