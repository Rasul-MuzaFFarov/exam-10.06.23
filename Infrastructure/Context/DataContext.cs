using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrasturcture.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Employees> Employees { get; set; }
}