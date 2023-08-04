using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Volunteer_Management_System.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IPersonRepository, FakePersonRepository>();
builder.Services.AddTransient<IAdminRepository, EFAdminRepository>();
builder.Services.AddTransient<IVolunteerRepository, EFVolunteerRepository>();
builder.Services.AddTransient<IOpportunityRepository, EFOpportunityRepository>();


builder.Services.AddMemoryCache();
builder.Services.AddSession();

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

app.UseSession();

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();