using Microsoft.AspNetCore.Mvc;
using WA_MVC_StandBlog.Data;
using WA_MVC_StandBlog.Models;

namespace WA_MVC_StandBlog.Controllers
{
    public class ContactController( StandBlogContext context)
        : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(model);
                context.SaveChanges();

                TempData["Message"] = "Mesajiniz basariyla gonderildi";

                return RedirectToAction(nameof(Contact));
            }
            return View(model);
           
        }
    }
}
