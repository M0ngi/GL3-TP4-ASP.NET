using System.Configuration;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TP4.Models;

namespace TP4.Data;

public class UniversityContext : DbContext
{

    private static UniversityContext? _instance;
    public DbSet<Student>? Student { get; set; }
    public static UniversityContext Instance
    {
        get
        {
            _instance ??= Instantiate_University_Context();
            return _instance;
        }
    }

    private UniversityContext(DbContextOptions o) : base(o) {
        Debug.WriteLine("New UniversityContext instance");
    }

    public static UniversityContext Instantiate_University_Context()
    {
        var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
        optionsBuilder.UseSqlite(@"Data Source=./tp4.db");

        return new UniversityContext(optionsBuilder.Options);
    }
}