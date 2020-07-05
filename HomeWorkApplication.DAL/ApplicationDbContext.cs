using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkApplication.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkApplication.DAL
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Cafe> Cafees { get; set; }

        public DbSet<Bucket> Buckets { get; set; }

        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
