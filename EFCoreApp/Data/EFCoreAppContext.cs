using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCoreApp.Models;

namespace EFCoreApp.Data
{
    public class EFCoreAppContext : DbContext
    {
        public EFCoreAppContext (DbContextOptions<EFCoreAppContext> options)
            : base(options)
        {
        }

        public DbSet<EFCoreApp.Models.AspNetRoles> AspNetRoles { get; set; }
    }
}
