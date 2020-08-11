using Business.Abstract.ServiceArticle;
using DataAccess.Abstract.IDalArticle;
using Entity.Entities.SchemaArticle;

namespace Business.Concrete.ConcreteArticle
{
    public class ConcreteArticle : ConcreteBase<Article,IDalArticle>, IArticleService
    {
        public ConcreteArticle(IDalArticle abstractDataAccess)
        {
            _abstractDataAccess = abstractDataAccess;
        }
    }
}
