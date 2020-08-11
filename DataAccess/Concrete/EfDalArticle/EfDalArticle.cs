using Core.Concrete.ORM;
using DataAccess.Abstract.IDalArticle;
using Entity.Entities.SchemaArticle;

namespace DataAccess.Concrete.EfDalArticle
{
    public class EfDalArticle : EfRepository<Article>, IDalArticle
    {
        public EfDalArticle(DigiTurkArticleDbContext digiTurkArticleDbContext)
        {
            dbContext = digiTurkArticleDbContext;
        }
    }
}
