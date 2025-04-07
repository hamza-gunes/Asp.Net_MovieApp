using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "anasayfa";

        }

        public string About()
        {
            return "hakkımızda";
        }
    }
}
