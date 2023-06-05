using health_and_fitness_app.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Reqster Adpe to server context
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer
(
builder.Configuration.GetConnectionString("MyConnect")
)
);
//Reqster Adpe to server context
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer
(
builder.Configuration.GetConnectionString("MyConnection")
)
);

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
