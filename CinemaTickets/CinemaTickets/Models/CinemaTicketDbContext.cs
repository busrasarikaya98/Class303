using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CinemaTicketDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=CinemaTicketDb;User Id=sa;Password=12345;");
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
