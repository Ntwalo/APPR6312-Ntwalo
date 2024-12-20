using Ntwalo_APPR6312.Data;
using Ntwalo_APPR6312.Interfaces;
using Ntwalo_APPR6312.Models;
using Ntwalo_APPR6312.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDisasterRepository, DisasterRepository>();
builder.Services.AddScoped<IDonationItemRepository, DonationItemRepository>();
builder.Services.AddScoped<IDonationMoneyRepository, DonationMoneyRepository>();
builder.Services.AddScoped<ICatagoryRepository, CatagoryRepository>();  
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

//if (args.Length == 1 && args[0].ToLower() == "seeddata")
//{
//    //Seed.SeedUsersAndRolesAsync(app);
//    Seed.SeedData(app);
//}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
