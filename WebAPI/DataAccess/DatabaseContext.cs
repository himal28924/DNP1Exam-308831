using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.DataAccess;

public class DatabaseContext : DbContext
{
    public DbSet<X> Xes { get; set; }

    public DbSet<Y> DbSet { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ExamTable");
    }

    
    /*  dotnet ef migrations add InitialCreate */
    /*  dotnet ef database update  */
}