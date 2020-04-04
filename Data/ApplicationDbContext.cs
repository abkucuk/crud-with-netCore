using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ozgunneonCom.Models;

namespace ozgunneonCom.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PhotoType> PhotoTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<PhotoType>()
            //    .HasMany(e => e.Photos)
            //    .WithOne(x => x.photoType);
           
        }
    }
}
