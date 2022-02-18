using Microsoft.EntityFrameworkCore;
//using MyWebApp.Data;
using MyWebApp.Models;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();

// builder.Services.AddDbContext<MyWebAppContext>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("MyWebAppContext")));



// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<MyWebAppContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MyWebAppContext")));
}
else
{
    builder.Services.AddDbContext<MyWebAppContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MyWebAppContext")));
}

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
