using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _2_03_2023_nevsehir_mvc.Models
{
    public class nevsehirDbContext : DbContext
    {
        public nevsehirDbContext(DbContextOptions<nevsehirDbContext> options) : base(options)
        {

        }   
        public DbSet<sliderTable> sliderTable { get; set; }
        public DbSet<sehirTable> sehirTable { get; set; }
        public DbSet<gezilecekYerlerTable> gezilecekYerlerTable { get; set; }
        public DbSet<detayResim> detayResim { get; set; }
    }
}
