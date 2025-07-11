using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _001_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace _001_webapi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}