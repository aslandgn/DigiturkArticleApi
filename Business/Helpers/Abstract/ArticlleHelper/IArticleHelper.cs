using Entity.Entities.SchemaArticle;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Helpers.Abstract.ArticlleHelper
{
    public interface IArticleHelper
    {
        Task<IEnumerable<Article>> ReadAllArticles();
        Task<IEnumerable<Article>> GetArticlesByHeaderAndContent(string filter);
        Task<IEnumerable<Article>> GetArticlesByHeader(string filter);
        Task<IEnumerable<Article>> GetArticlesByContent(string filter);
        Task<Article> GetById(int id);
        Task<Article> UpdateArticle(Article article);
        Task<Article> Add(Article article);
        Task Delete(int id);
    }
}
