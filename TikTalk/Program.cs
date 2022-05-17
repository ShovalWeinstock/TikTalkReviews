using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TikTalk.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TikTalkContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TikTalkContext") ?? throw new InvalidOperationException("Connection string 'TikTalkContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Reviews}/{action=Search}/{id?}");

app.Run();
