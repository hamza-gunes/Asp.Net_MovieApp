using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
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
