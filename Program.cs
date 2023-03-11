global using fin;
global using System.Linq.Expressions;
global using fin.Models;
global using fin.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);

// Add context
builder.Services.AddDbContext<FinContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("finPsql")));
// Add services to the container.
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.UseAuthentication();
app.UseAuthorization();

app.Run();