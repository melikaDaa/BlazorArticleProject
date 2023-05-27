using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Shared.Entities;

namespace MyProject.Shared.DTo
{

    public class PageList<T> : List<T>
    {
      public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;

        public PageList(List<T>items,int count,int pageNumber, int pageSize)
        {
            TotalCount = count;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            PageSize = pageSize;
            AddRange(items);
        }

     

        public static PageList<T> GetPagedList(IOrderedQueryable<T> source,int PageNumber,int PageSize)
        {
            var count = source.Count();
            var items = source.Skip((PageNumber - 1) * PageSize).Take(PageSize).ToList();
            return new PageList<T>(items, count, PageNumber, PageSize);
        }
    }
}
