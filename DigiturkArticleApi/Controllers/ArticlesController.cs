using Business.Abstract.ServiceArticle;
using Entity.Entities.SchemaArticle;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiturkArticleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET: api/Articles
        [HttpGet]
        public async Task<IEnumerable<Article>> GetArticles()
        {
            try
            {
                return await _articleService.GetList();

            }
            catch (Exception e)
            {

                throw;
            }
        }

        // GET: api/Articles/searcOnlyHeaders/header
        [HttpGet("searchOnlyHeaders/{filter}")]
        public async Task<IEnumerable<Article>> GetArticlesByHeader(string filter)
        {
            try
            {
                return await _articleService.GetList(x => x.HEADER.Contains(filter));

            }
            catch (Exception e)
            {

                throw;
            }
        }

        // GET: api/Articles/searcOnlyHeaders/header
        [HttpGet("searchOnlyContent/{filter}")]
        public async Task<IEnumerable<Article>> GetArticlesByContent(string filter)
        {
            try
            {
                return await _articleService.GetList(x => x.CONTENT.Contains(filter));

            }
            catch (Exception e)
            {

                throw;
            }
        }

        // GET: api/Articles/searcOnlyHeaders/header
        [HttpGet("searchFullArticle/{filter}")]
        public async Task<IEnumerable<Article>> GetArticlesByHeaderAndContent(string filter)
        {
            try
            {
                return await _articleService.GetList(x => x.HEADER.Contains(filter) || x.CONTENT.Contains(filter));

            }
            catch (Exception e)
            {

                throw;
            }
        }

        // GET: api/Articles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticle(int id)
        {
            var article = await _articleService.Get(x => x.ID == id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticle(int id, Article article)
        {
            try
            {
                if (id != article.ID)
                {
                    return BadRequest();
                }
                var entity = await _articleService.Get(x => x.ID == id);
                entity.HEADER = article.HEADER;
                entity.CONTENT = article.CONTENT;
                entity.STATUS = article.STATUS;
                try
                {
                    await _articleService.Update(entity);
                    return Ok();
                }
                catch (Exception e)
                {

                    return BadRequest("Error on Update");
                }

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // POST: api/Articles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Article>> PostArticle(Article article)
        {
            try
            {
                await _articleService.Add(article);

                return CreatedAtAction("GetArticle", new { id = article.ID }, article);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Article>> DeleteArticle(int id)
        {
            var article = await _articleService.Get(x => x.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            await _articleService.Delete(article);

            return Ok();
        }

        private async Task<bool> ArticleExistsAsync(int id)
        {
            var result = await _articleService.GetList(x => x.ID == id);
            return result.Any();
        }
    }
}
