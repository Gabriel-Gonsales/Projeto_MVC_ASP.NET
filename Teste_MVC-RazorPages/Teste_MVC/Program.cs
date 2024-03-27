using Microsoft.Extensions.FileSystemGlobbing.Internal;
using MVC_ASP.NET.Model.Business;
using MVC_ASP.NET.Model.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<ILivroRepository,LivroRepository>();
builder.Services.AddScoped<LivroService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "livros",
    pattern: "Livros/{action=Index}",
    defaults: new { controller = "Livros", action = "Index" }
);
app.MapRazorPages();

app.Run();
