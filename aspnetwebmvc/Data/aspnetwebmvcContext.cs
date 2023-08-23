using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aspnetwebmvc.Models;

namespace aspnetwebmvc.Data
{
    public class aspnetwebmvcContext : DbContext
    {
        public aspnetwebmvcContext (DbContextOptions<aspnetwebmvcContext> options)
            : base(options)
        {
        }

        public DbSet<aspnetwebmvc.Models.Movie> Movie { get; set; } = default!;
    }
}
