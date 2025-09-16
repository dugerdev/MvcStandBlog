using Microsoft.AspNetCore.Mvc;

namespace WA_MVC_StandBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
