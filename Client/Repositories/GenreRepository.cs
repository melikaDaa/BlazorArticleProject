using MyProject.Client.Helpers;
using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Client.Repositories
{
    public class GenreRepository:IGenreRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/Category";

        public GenreRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateGenre(Categories genre)
        {
            var response = await httpService.Post(url, genre);

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task UpdateGenre(Categories genre)
        {
            var response = await httpService.Put(url, genre);

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task<List<Categories>> GetGenres()
        {
            var response = await httpService.Get<List<Categories>>(url);

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task<Categories> GetGenre(int id)
        {
            var response = await httpService.Get<Categories>($"{url}/{id}");

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
        public async Task<Categories> DeleteGenre(int id)
        {
            var response = await httpService.Delete<Categories>($"{url}/{id}");

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}
