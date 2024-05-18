using Microsoft.EntityFrameworkCore;
using Solid.Models;

namespace Solid.Data{
    public class BaseContext : DbContext{ 
        
    public DbSet<Company> Companies { get; set; }
    public BaseContext(DbContextOptions<BaseContext> options) : base(options)
    {
        
    } 
    
    }
}