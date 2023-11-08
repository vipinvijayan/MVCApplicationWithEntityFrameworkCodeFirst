# MVCApplicationWithEntityFrameworkCodeFirst
MVC Sample Application with Entity Framework Code First Approach


#**Create New mvc core application with name DryCleanerApp with Target framework .Net7  **



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


**Add Connecton string for MySql on program.cs file on application**

string? dbConnectionString = builder.Configuration.GetConnectionString("AppConnection");

builder.Services.AddDbContext<DryCleanerContext>(options =>
options.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString))
);

**Add new class library for buissiness logic with name DryCleanerAppBussinessLogic with Target framework .Net7  **


**Add new class library for buissiness logic with name DryCleanerAppDataAccess with Target framework .Net7  **


**Company Entity Model **

 public class CompanyEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string CompanyName { get; set; }
    [MaxLength(300)]
    public string? CompanyDescription { get; set; }
    [MaxLength(300)]
    public string? CompanyAddress { get; set; }
    [MaxLength(100)]
    public string? Place { get; set; }
    [MaxLength(100)]
    public string? LandMark { get; set; }
    [MaxLength(100)]
    public string? CompanyCity { get; set; }
    [MaxLength(100)]
    public string? CompanyState { get; set; }
    [MaxLength(100)]
    public string? CompanyCountry { get; set; }
    [MaxLength(15)]
    public string? CompanyPhone { get; set; }
    [MaxLength(100)]
    public string? CompanyEmail { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public int CreatedOn { get; set; } = (int)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;
    public int UpdatedOn { get; set; } = (int)DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;
    public bool IsDeleted { get; set; } = false;
    public bool IsActive { get; set; } = true;

}

