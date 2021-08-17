using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webCorePractice20210816.Models;

namespace webCorePractice20210816.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Article> articles { get; set; }
        public MyDbContext(DbContextOptions options) 
            : base(options)
        {
        }

       
       
    }
}
