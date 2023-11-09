# MVCApplicationWithEntityFrameworkCodeFirst
MVC Sample Application with Entity Framework Code First Approach
Step 1
Create new MVC Application from visual studio

![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/ef58b58b-8b41-450e-9d90-2864c9f53df2)
 

 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/4bed5124-784e-46b0-baaa-25d58513fd7f)

Figure 2 – Select MVC Template

 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/4ba86084-20f5-4f98-a1c9-b791987faa49)

Figure 3 – Give project name and select location for saving project files

 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/a4e59e01-9e05-4820-9dbc-3d85c4d6cb1d)

Figure 4 – Select Faremwork (.Net6) 


 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/02d8c451-7bff-488c-8585-bef91bb4b7b0)

Figure 5 – Project created you can check on the Solution explorer Right Side
If getting build errors Install Microsoft.EntityFrameworkCore.Design, Microsoft.EntityFrameworkCore.Tools, MySql.Data Using nuget package manager

Step 2
Create New Class Library for business logic related files to save.
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/d3a80671-e513-4932-a60a-bbb6cdb2503e)

Figure 1 – Select class library from project template list

 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/32d761c4-b4d1-49d8-9bd7-82defd7aa0d4)

Figure 2 – Giving Proper name and selecting proper Folder for class library
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/7b97e69a-a3be-4ae0-a5c8-0f36d1332e54)

Figure 3 – Select Framework (.Net6)
If getting build errors Install Microsoft.Extensions.DependencyInjection.Abstractions using nuget package manager
Step 3 
Create Class library for Data Access 
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/10091710-9737-4461-8a82-af6419163382)

Figure 1 – Select class library from project template list

 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/5b8c11af-36ea-4cfd-b41f-9578d419f81c)

Figure 2 – Giving Proper name and selecting proper Folder for class library
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/f6a08bcc-ef8e-4fe7-ac35-941d0bfbcc51)

Figure 3 – Select Framework (.Net6)
If getting build errors  Install Microsoft.EntityFrameworkCore ,Pomelo.EntityFrameworkCore.MySql, Microsoft.EntityFrameworkCore.Relational, on the dataccess layer using nuget package manager
After creating projects we can start with creating Db Context 
For that create a new class named DryCleanerContext in new folder DataAccess
 
![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/ae3211b4-981a-411a-bb3d-d9198c453c95)

•	Add Constrictor for DryCleanerContext
   public DryCleanerContext(DbContextOptions<DryCleanerContext> options) : base(options) { }
•	Then add Dbset to create Table on the database
public DbSet<CompanyEntity> companyEntities { get; set; }
public DbSet<UserEntity> users { get; set; }
public DbSet<UserAddressEntity> usersAddress { get; set; }

Create new class named ApplicationDbContextFactory
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/83fb925b-3cba-4dbb-9a6d-c4ac70dab7e0)

If you are trying to create scaffolded item or controller with read/write actions you need to this create the above class in DataAccess Folder.
![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/15ca7bbf-8b1a-4915-a8ea-4e3730030982)

 
Add Entity classes to on entities folder as shown in figure.These classes in entity folder is used in DryCleanerContext class.
After creating Entity classes and dbcontext class we need to run some codes in Package Manager Console to effect the changes on the db context and entities in Database.


Step 1 – Run command “Add-Migration Nameforthemigration”
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/b85abc94-e001-425f-a81c-8408db6b45d2)

It will get the below image if success
 
![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/5f280eef-2ff6-4d53-86ea-40475ec5e317)

If getting error please check for the default project on the package manager console.Or check the connection string given are correct on both ApplicationDbContextFactory and  appsettings.json file.

Step 2 – Run Command “database-update”
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/56551ded-326d-4119-af51-719177b37206)

You will get message the the migration created effected to database. Here showing 3 migration as there already created 2 migration before doing this explanation.

 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/1061bc35-1092-43ab-836a-1180a15201f6)

You can create new classes for using in application controllers in Model folder 

 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/33908f73-00ff-42ae-870f-58e1526cc4f2)

Then Create Interface for Repository files to access from bussinesslogic layer ICompanyrepositry.
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/9a655faa-3fd7-46a1-9b89-06b25361e76f)

Then Create Repository files to access data from database using Entity Framework named Companyrepositry.

Then We need to create buissiness classes .
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/be6cbf62-7f40-4d7e-b54a-0e564b3ae7a1)

Create business files (Interface and its implementation) as show in the above figure.
 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/d78e178d-43ce-4b7c-a98e-2c3e708169fc)

Business login Implementation class.
Used IRepository interface for getting data from database to the business layer.
The below code is populating entity class from the company model getting from the controller method.
    public async Task<string> CreateCompany(CompanyModel param)
    {
        var companyData = new CompanyEntity()
        {
            CompanyAddress = param.CompanyAddress,
            CompanyCity = param.CompanyCity,
            CompanyName = param.CompanyName,
            CompanyPhone = param.CompanyPhone,
            CompanyCountry = param.CompanyCountry,
            CompanyState = param.CompanyState,
            CompanyDescription = param.CompanyDescription,
            CompanyEmail = param.CompanyEmail,
            LandMark = param.LandMark,
            Place = param.Place,
            CreatedBy = param.CreatedBy,
        };
        return await _companyRepository.CreateCompany(companyData);
    }


 ![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/76bb8e03-9d0b-41bd-ab58-480c2e922915)

Interface class for the business logic layer.


Then we can inject repository layer and business layer to our mvc application middle ware for running the application.
Code in Program.cs


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

//getting connection string from appsettings.json
string? dbConnectionString = builder.Configuration.GetConnectionString("AppConnection");

//adding DB Context for mysql connection
builder.Services.AddDbContext<DryCleanerContext>(options =>
options.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString))
);
//Adding Repository for dependency injection
builder.Services.AddRepositoryDependecies();
//Adding Buissiness logic files 
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




