using Microsoft.AspNetCore.Mvc;

namespace WA_MVC_StandBlog.Controllers
{
    public class PostDetailsController : Controller
    {
        public IActionResult PostDetails()
        {
            return View();
        }
    }
}
