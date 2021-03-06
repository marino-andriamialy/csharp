#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

    public class MyWebAppContext : DbContext
    {
        public MyWebAppContext (DbContextOptions<MyWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyWebApp.Models.Movie> Movie { get; set; }
    }
