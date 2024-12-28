using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ToDoList.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ToDoListDbContextFactory : IDesignTimeDbContextFactory<ToDoListDbContext>
{
    public ToDoListDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        ToDoListEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<ToDoListDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new ToDoListDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ToDoList.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
