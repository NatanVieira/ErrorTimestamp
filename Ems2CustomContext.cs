using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ErrorTimestamp 
{ 
    class Ems2CustomContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOpenEdge("DSN=DSN_Database;HOST=HOSTNAME;port=99999;UID=pub;PWD=pub;DIL=1;Database=database_name");
        }

        public DbSet<SpoClientes> SClientes { get; set; }
    }
}
