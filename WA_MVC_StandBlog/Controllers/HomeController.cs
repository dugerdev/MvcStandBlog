using Microsoft.AspNetCore.Mvc;

namespace WA_MVC_StandBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
