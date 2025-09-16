using Microsoft.AspNetCore.Mvc;

namespace WA_MVC_StandBlog.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
