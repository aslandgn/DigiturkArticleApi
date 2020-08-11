using Entity.Entities.SchemaArticle;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DigiTurkArticleDbContext: DbContext
    {
        public DigiTurkArticleDbContext()
        {
        }
        public DigiTurkArticleDbContext(DbContextOptions<DigiTurkArticleDbContext> options) : base(options)
        {

        }
        public DbSet<Article> Articles{ get; set; }


    }
}
