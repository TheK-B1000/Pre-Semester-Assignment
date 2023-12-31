using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Volunteer_Management_System.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IDatabaseRepository, DatabaseRepository>();
builder.Services.AddTransient<IPersonRepository, EFPersonRepository>();
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
app.UseSession();
app.UseRouting();
app.UseAuthorization();

app.MapGet("/hi", () => "Hello There!");

app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Person}/{action=List}/{id?}");

app.MapDefaultControllerRoute();
app.MapControllers();
app.MapRazorPages();

app.Run();