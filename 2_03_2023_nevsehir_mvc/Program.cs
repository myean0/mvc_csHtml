using _2_03_2023_nevsehir_mvc.Models;
using _2_03_2023_nevsehir_mvc.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddScoped<ISliderTableRepository, SqlSliderTableRepository>();
builder.Services.AddScoped<ISehirTableRepository , SqlSehirTableRepository>();
builder.Services.AddScoped<IGezilecekYerlerTableRepository, SqlGezilecekYerlerTableRepository>();
builder.Services.AddDbContextPool<nevsehirDbContext>(options =>
{
  options.UseSqlServer(builder.Configuration.GetConnectionString("nevsehirAppConnection"));
});

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
  name: "Default",
  pattern: "{Controller=Home}/{Action=Index}/{Id?}"
);

app.Run();