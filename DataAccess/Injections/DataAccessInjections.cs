using DataAccess.Abstract.IDalArticle;
using DataAccess.Concrete.EfDalArticle;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Injections
{
    public static class DataAccessInjections
    {
        public static void Initialize(IServiceCollection services)
        {

            #region Article
            services.AddTransient<IDalArticle, EfDalArticle>();
            #endregion
        }
    }
}
