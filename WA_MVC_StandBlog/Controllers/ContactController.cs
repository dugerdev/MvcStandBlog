using Microsoft.AspNetCore.Mvc;
using WA_MVC_StandBlog.Data;
using WA_MVC_StandBlog.Models.Entities;

namespace WA_MVC_StandBlog.Controllers
{
    /// <summary>
    /// İletişim formu işlemlerini yöneten controller
    /// </summary>
    public class ContactController(StandBlogContext context) : Controller
    {
        /// <summary>
        /// İletişim sayfasını görüntüler
        /// </summary>
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// İletişim formundan gelen mesajı işler ve veritabanına kaydeder
        /// </summary>
        /// <param name="model">İletişim formu modeli</param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                // Mesajı veritabanına kaydet
                context.Contacts.Add(model);
                context.SaveChanges();

                // Başarı mesajını ayarla
                TempData["Message"] = "Mesajınız başarıyla gönderildi";

                // Aynı sayfaya yönlendir
                return RedirectToAction(nameof(Contact));
            }
            
            // Model geçersizse formu tekrar göster
            return View(model);
        }
    }
}
