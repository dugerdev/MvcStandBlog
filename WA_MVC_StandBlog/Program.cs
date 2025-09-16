using Microsoft.EntityFrameworkCore;
using WA_MVC_StandBlog.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<StandBlogContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

app.UseStaticFiles();


app.MapControllerRoute(
    name:"Default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );



app.Run();
