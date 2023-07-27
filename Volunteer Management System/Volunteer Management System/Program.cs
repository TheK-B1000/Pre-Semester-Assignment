using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Volunteer_Management_System.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IPersonRepository, FakePersonRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapGet("/hi", () => "Hello There!");

app.MapControllerRoute(
 name: null,
 pattern: "{category}/Page{page:int}",
 defaults: new { Controller = "Person", action = "List" });

app.MapControllerRoute(
 name: null,
 pattern: "Page{page:int}",
 defaults: new { Controller = "Person", action = "List", page = 1 });

app.MapControllerRoute(
 name: null,
 pattern: "{category}",
 defaults: new { Controller = "Person", action = "List", page = 1 });

app.MapControllerRoute(
 name: null,
 pattern: "",
 defaults: new { Controller = "Person", action = "List", page = 1 });

app.MapControllerRoute(
 name: "pagination",
 pattern: "People/Page{page}",
 defaults: new { Controller = "Person", action = "List" });

app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Person}/{action=List}/{id?}");

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();