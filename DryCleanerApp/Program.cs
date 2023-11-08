
using DryCleanerAppBussinessLogic;
using DryCleanerAppBussinessLogic.Implementation;
using DryCleanerAppBussinessLogic.Interfaces;
using DryCleanerAppDataAccess.IRepository;
using DryCleanerAppDataAccess.Repository;
using DryCleanerAppDataAccess.DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string? dbConnectionString = builder.Configuration.GetConnectionString("AppConnection");

builder.Services.AddDbContext<DryCleanerContext>(options =>
options.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString))
);
builder.Services.AddRepositoryDependecies();
builder.Services.AddScoped<ICompanyB, CompanyB>();

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
    pattern: "{controller=CompanyMaster}/{action=CompanyList}/{id?}");

app.Run();
