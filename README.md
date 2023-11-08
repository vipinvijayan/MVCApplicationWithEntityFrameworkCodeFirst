# MVCApplicationWithEntityFrameworkCodeFirst
MVC Sample Application with Entity Framework Code First Approach




In DryCleanerApp (MVC App) main things to cover

**Make changes on application config for connection string**
{
  "ConnectionStrings": {
    "AppConnection": "Your Connectionstring here"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}


**Adding Connecton string for MySql on program.cs file on application**

string? dbConnectionString = builder.Configuration.GetConnectionString("AppConnection");

builder.Services.AddDbContext<DryCleanerContext>(options =>
options.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString))
);


* Changed Default Route

  app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CompanyMaster}/{action=CompanyList}/{id?}");

**Added files for Dependecy Injection**

  *Added Service Repositories from dataaccess layer

    builder.Services.AddRepositoryDependecies();

  *Added Bussiness Logic Files 
  
    builder.Services.AddScoped<ICompanyB, CompanyB>();


  **In DryCleanerAppBussinessLogic (class library for buissiness logic) main things to cover**

Add IServiceCollectionExtension Class for adding repository dependecies 
![image](https://github.com/vipinvijayan/MVCApplicationWithEntityFrameworkCodeFirst/assets/8413745/8cab83ba-d90e-4f82-8a2e-225ca78a9011)
