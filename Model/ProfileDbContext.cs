using Microsoft.EntityFrameworkCore;
using Model.Domain;

namespace Model
{
    public class ProfileDbContext : DbContext
    {
         public ProfileDbContext(DbContextOptions <ProfileDbContext> options)
            : base(options)
        {

        }
        public DbSet<Type> Types { get; set; }
        public DbSet<Article> Articles { get; set; }

    }
}
