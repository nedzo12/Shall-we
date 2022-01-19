using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Shallwe.Server;
using Shallwe.Server.servisi;
using Sitecore.FakeDb;
using Db = Shallwe.Server.Db;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddTransient<ProfesorServis>();

builder.Services.AddDbContext<Db>(opcije =>
opcije.UseSqlServer(builder.Configuration.GetConnectionString("Lokalna Baza")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapHub<ProfesoriHub>("ProfesoriHub");
app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
