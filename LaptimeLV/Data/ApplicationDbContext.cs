using System;
using System.Collections.Generic;
using System.Text;
using LaptimeLV.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LaptimeLV.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        
        public virtual DbSet<Track> Tracks { get; set; }
        
        public DbSet<LaptimeLV.Models.Car> Car { get; set; }
    }
}
