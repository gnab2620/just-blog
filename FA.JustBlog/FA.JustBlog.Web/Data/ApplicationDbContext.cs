using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FA.JustBlog.Web.Models;

namespace FA.JustBlog.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Tags> Tags { get; set; }

        public DbSet<PostTagMap> PostTagMaps { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PostTagMap>().HasKey(sc => new { sc.PostId, sc.TagId });
            builder.Entity<PostTagMap>()
    .HasOne<Posts>(sc => sc.Post)
    .WithMany(s => s.PostTagMap)
    .HasForeignKey(sc => sc.PostId);


            builder.Entity<PostTagMap>()
                .HasOne<Tags>(sc => sc.Tags)
                .WithMany(s => s.PostTagMap)
                .HasForeignKey(sc => sc.TagId);
            base.OnModelCreating(builder);
        }




        

      

      


    }
}
