using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryCleanerAppDataAccess.DataAccess
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<DryCleanerContext>
    {
        public DryCleanerContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DryCleanerContext>();
            optionsBuilder.UseMySql("Your Connection String", ServerVersion.AutoDetect("Your Connection String"));
            return new DryCleanerContext(optionsBuilder.Options);
        }
    }
}
