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
            optionsBuilder.UseOpenEdge("DSN=HOMOL_ems2custom;HOST=ZEUS;port=48001;UID=pub;PWD=pub;DIL=1;Database=ems2custom");
        }

        public DbSet<SpoClientes> SClientes { get; set; }
    }
}
