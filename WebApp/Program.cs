using BLL.Services;
using BLL.Services.Contracts;
using DAL.DataContext;
using DAL.Reponsitories.Contracts;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<test_3_tier_core_6Context>(options =>
{
    var connetionString = builder.Configuration.GetConnectionString("mysql");
    options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
});

builder.Services.AddTransient(typeof(IGenericReponsitory<>), typeof(IGenericReponsitory<>));
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
