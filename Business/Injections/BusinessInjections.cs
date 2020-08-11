using Business.Abstract.ServiceArticle;
using Business.Concrete.ConcreteArticle;
using Business.Helpers.Abstract.ArticlleHelper;
using Business.Helpers.Concrete.ArticlleHelper;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Injections
{
    public static class BusinessInjections
    {
        public static void Initialize(IServiceCollection services)
        {
            #region Article
            services.AddTransient<IArticleService, ConcreteArticle>();
            services.AddTransient<IArticleHelper, ArticleHelper>();
            #endregion
        }
    }
}
