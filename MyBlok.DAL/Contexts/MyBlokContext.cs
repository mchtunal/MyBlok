using Microsoft.EntityFrameworkCore;
using MyBlok.DAL.Confing;
using MyBlok.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlok.DAL.Contexts
{
    class MyBlokContext:DbContext
    {
        public MyBlokContext(DbContextOptions<MyBlokContext> options):base(options)
        {
            //Veri tabanının oluşturulduğundan emin ol ve güncel olduğundan da emin ol
            Database.EnsureCreated();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
