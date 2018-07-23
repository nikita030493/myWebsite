using Microsoft.EntityFrameworkCore;

namespace NikitaDev
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) 
            : base(options)
        {   
        }

    }
}