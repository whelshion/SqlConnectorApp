using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options)
            : base(options)
        {
        }

        public DbSet<EFCoreMySqlApp.Models.AspNetRoles> AspNetRoles { get; set; }
    }
}
