using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.Server.DbContext;
using MyProject.Server.Utilities;
using MyProject.Shared.DTo;
using MyProject.Shared.Entities;

namespace MyProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ArticlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IndexPageDTO>> Get()
        {
            var limit = 6;

            var moviesInTheater = await _context.Articles
                .Where(s => s.InTheater)
                .OrderByDescending(s => s.ReleasTime)
                .Select(s => new Article
                {
                   
                    ReleasTime = s.ReleasTime,
                    InTheater = s.InTheater,
                    ArticleId = s.ArticleId,
                    Poster = PathTools.MoviePosterShowAddress + s.Poster,
                    Sumamary = s.Sumamary,            
                    Title = s.Title,
                    Trailer = s.Trailer
                })
                .Take(limit)
                .ToListAsync();

            var upcomingReleases = await _context.Articles
                .Where(s => s.ReleasTime == DateTime.Today)
                .OrderByDescending(s => s.ReleasTime)
                .Select(s => new Article
                {
                
                    ReleasTime = s.ReleasTime,
                    InTheater = s.InTheater,
                    ArticleId = s.ArticleId,
                    Poster = PathTools.MoviePosterShowAddress + s.Poster,
                    Sumamary = s.Sumamary,
                    Title = s.Title,
                    Trailer = s.Trailer
                })
                .Take(limit)
                .ToListAsync();

            return new IndexPageDTO
            {
                Copyright = moviesInTheater,
                ReleasesTime = upcomingReleases
            };
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArticleDetailsDto>> Get(int id)
        {
            var movie = await _context.Articles
                .Include(s => s.Categories)    
                .SingleOrDefaultAsync(s => s.ArticleId == id);

            if (movie == null) return NotFound();

            var model = new ArticleDetailsDto();
            model.Article = movie;
            model.Article.Poster = PathTools.MoviePosterShowAddress + movie.Poster;

            return model;
        }

     
        


        [HttpPost]
        public async Task<ActionResult<int>> PostArticle(Article article)
        {
            var image = Convertors.Base64ToImage(article.Poster);
            var imageName = Guid.NewGuid().ToString("N") + ".jpeg";
            image.AddImageToServer(imageName, PathTools.MoviePosterAddress);
            article.Poster = imageName;
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return article.ArticleId;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

   
    }
}
