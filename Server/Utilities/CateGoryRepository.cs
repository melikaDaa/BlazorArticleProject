using MyProject.Shared.DTo;
using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Server.DbContext;

namespace MyProject.Server.Utilities
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly ApplicationDbContext Context;

        public CategoryRepository(ApplicationDbContext context)
        {
            Context = context;
        }

      //  public Task<PageList<Categories>> GetCategory(PaginationDto pagingParameters)
    //    {
  //          return Task.FromResult(PageList<Categories>.GetPagedList(FindAll().OrderBy(s => s.Id),
//                pagingParameters.PageNumber, pagingParameters.PageSize));

        //}
     

        public IQueryable<Categories> FindAll()
        {
            return Context.Categories.AsQueryable();
        }

    }

    public interface ICategoryRepository
    {
      //  Task<PageList<Categories>> GetCategory(PaginationDto pagingParameters);

    }
}
