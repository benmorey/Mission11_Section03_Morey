using Microsoft.EntityFrameworkCore;
using Mission11_Section03_Morey.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BookstoreContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:WaterConneciton"]);
});

builder.Services.AddScoped<IBooks, EBooks>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute("pagination", "Projects/page{pageNum}", new {Controller = "Home", action = "Index"});
app.MapDefaultControllerRoute();

app.Run();
