using BLL.Services;
using BLL.Services.Contracts;
using DAL.DataContext;
using DAL.Reponsitories;
using DAL.Reponsitories.Contracts;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("mysql");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<test_3_tier_core_6Context>(
            dbContextOptions => dbContextOptions.UseMySql(connectionString, serverVersion)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
        );


builder.Services.AddTransient(typeof(IGenericReponsitory<>), typeof(Reponsitory<>));
builder.Services.AddScoped<INhanVienServices, NhanVienServices>();

var app = builder.Build();

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
    pattern: "{controller=Home}/{action=ListNhanVien}/{id?}");

app.Run();
