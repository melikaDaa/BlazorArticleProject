using MyProject.Shared.DTo;
using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Client.Repositories
{
   public interface IArticleRepository
    {
        Task<int> CreateArticle(Article article);
        Task<IndexPageDTO> GetIndexPageDTO();
        Task<ArticleDetailsDto> GetDetailArticleDTO(int id);
        Task<Article> DeleteArticle(int id);
    }
}
