using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Server.Utilities
{
    public static class HtppContextExtensions
    {
        public static async Task InsertPaginationParamertInResponse<T>(this HttpContext httpContext,
            IQueryable<T> queryable,int recordsPerPage )
        {
            double count = await queryable.CountAsync();
            double pagesQuantity = Math.Ceiling(count / recordsPerPage);
            httpContext.Response.Headers.Add("pagesQuantity",pagesQuantity.ToString());

        }
    }
}
