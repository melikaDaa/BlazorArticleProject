using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Server.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Article>()
        .HasOne(a => a.Categories)
        .WithOne(b => b.Articles)
        .HasForeignKey<Article>(b => b.CategoryId);

            base.OnModelCreating(modelBuilder);



        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Categories> Categories { get; set; }


    }
}
