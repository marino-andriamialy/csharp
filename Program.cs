using Microsoft.EntityFrameworkCore;
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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
