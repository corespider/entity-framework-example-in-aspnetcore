using Microsoft.EntityFrameworkCore;
using MVCCore.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.EF.Context
{
    public class DBContextEF : DbContext
    {
        public DBContextEF(DbContextOptions<DBContextEF> options) : base(options)
        {
        }

        public DbSet<States> States { get; set; }
    }
}
