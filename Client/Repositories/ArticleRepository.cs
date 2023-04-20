using MyProject.Client.Helpers;
using MyProject.Shared.DTo;
using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Client.Repositories
{
    public class ArticleRepository:IArticleRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/Articles";
        public ArticleRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

   

        public async Task<int> CreateArticle(Article article)
        {
            var result = await httpService.Post<Article, int>(url, article);

            if (!result.IsSuccess)
            {
                throw new ApplicationException(await result.GetBody());
            }

            return result.Response;
        }

        public async Task<IndexPageDTO> GetIndexPageDTO()
        {
            return await Get<IndexPageDTO>(url);
        }
        public async Task<T> Get<T>(string url)
        {
            var response = await httpService.Get<T>(url);
            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task<ArticleDetailsDto> GetDetailArticleDTO(int id)
        {
            return await Get<ArticleDetailsDto>($"{url}/{id}");
        }

        public async Task<Article> DeleteArticle(int id)
        {
            var response = await httpService.Delete<Article>($"{url}/{id}");

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}
