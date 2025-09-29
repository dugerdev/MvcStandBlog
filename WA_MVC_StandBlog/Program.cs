using Microsoft.EntityFrameworkCore;
using WA_MVC_StandBlog.Data;

// Web uygulaması oluşturucu
var builder = WebApplication.CreateBuilder(args);

// Entity Framework DbContext'i SQL Server ile yapılandır
builder.Services.AddDbContext<StandBlogContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// MVC servislerini ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Routing middleware'ini etkinleştir
app.UseRouting();

// Statik dosyalar için middleware
app.UseStaticFiles();

// Varsayılan controller route'u tanımla
app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

// Uygulamayı başlat
app.Run();
