using Microsoft.EntityFrameworkCore;
using StudentApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add MVC services
builder.Services.AddControllersWithViews();

// Configure MySQL / Entity Framework Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

// Configure error handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// HTTPS redirect disabled because this lab is running on HTTP
// app.UseHttpsRedirection();

// IMPORTANT: Enable CSS, JavaScript, images, Bootstrap, etc.
// from the wwwroot folder.
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Default MVC route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();