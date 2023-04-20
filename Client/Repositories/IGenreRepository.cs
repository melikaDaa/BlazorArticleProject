using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Client.Repositories
{
    public interface IGenreRepository
    {
        Task CreateGenre(Categories genre);
        Task<List<Categories>> GetGenres();
        Task UpdateGenre(Categories genre);
        Task<Categories> GetGenre(int id);

        Task<Categories> DeleteGenre(int id);
    }
}
