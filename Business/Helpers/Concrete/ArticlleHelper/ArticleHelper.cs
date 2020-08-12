using Business.Abstract.ServiceArticle;
using Business.Helpers.Abstract.ArticlleHelper;
using Entity.Entities.SchemaArticle;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Helpers.Concrete.ArticlleHelper
{
    public class ArticleHelper : IArticleHelper
    {
        IArticleService _articleService;
        public ArticleHelper(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<Article> Add(Article article)
        {
            try
            {
                return await _articleService.Add(article);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                var article = await GetById(id);
                if (article == null)
                {
                    throw new Exception("article not found");
                }
                await _articleService.Delete(article);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Article>> GetArticlesByContent(string filter)
        {
            try
            {
                return await _articleService.GetList(x => x.CONTENT.Contains(filter));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Article>> GetArticlesByHeader(string filter)
        {
            try
            {
                return await _articleService.GetList(x => x.HEADER.Contains(filter));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Article>> GetArticlesByHeaderAndContent(string filter)
        {
            try
            {
                return await _articleService.GetList(x => x.HEADER.Contains(filter) || x.CONTENT.Contains(filter));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Article> GetById(int id)
        {
            try
            {
                return await _articleService.Get(x => x.ID == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Article>> ReadAllArticles()
        {
            try
            {
                return await _articleService.GetList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Article> UpdateArticle(Article article)
        {
            try
            {
                var entity = await _articleService.Get(x => x.ID == article.ID);
                entity.HEADER = article.HEADER;
                entity.CONTENT = article.CONTENT;
                entity.STATUS = article.STATUS;
                return await _articleService.Update(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
