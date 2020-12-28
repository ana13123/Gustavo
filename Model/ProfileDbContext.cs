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
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<Article> Articles { get; set; }

    }
}
