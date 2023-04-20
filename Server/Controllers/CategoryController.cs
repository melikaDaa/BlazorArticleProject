using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.Server.DbContext;
using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext Context;

        public CategoryController(ApplicationDbContext context)
        {
            this.Context = context;
        }
        [HttpGet("GetCategory")]
        [HttpGet]
        public async Task<List<Categories>> Get()
        {
            return await Context.Categories.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Categories>> Get(int id)
        {
            var genre = await Context.Categories.SingleOrDefaultAsync(s => s.Id == id);
            if (genre == null) return NotFound();
            return genre;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Categories genre)
        {
            await Context.AddAsync(genre);
            await Context.SaveChangesAsync();

            return genre.Id;
        }
        public async Task<ActionResult> Put(Categories genre)
        {
            Context.Update(genre);
            await Context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var categories = await Context.Categories.FindAsync(id);
            if (categories == null)
            {
                return NotFound();
            }

            Context.Categories.Remove(categories);
            await Context.SaveChangesAsync();

            return NoContent();
        }

    }
}
