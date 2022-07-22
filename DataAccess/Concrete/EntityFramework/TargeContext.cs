using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class TargeContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-AR4MMNII\SQLEXPRESS;Database=TargeGuide;Trusted_Connection=true");
        }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Content> Contents{ get; set; }
        public DbSet<Document> Documents{ get; set; }
        public DbSet<GuideKeyword> GuideKeywords{ get; set; }
        public DbSet<Keyword> Keywords{ get; set; }
        public DbSet<Language> Languages{ get; set; }
        public DbSet<Routing> Routings{ get; set; }
        public DbSet<Platform> Platforms{ get; set; }

    }
}
