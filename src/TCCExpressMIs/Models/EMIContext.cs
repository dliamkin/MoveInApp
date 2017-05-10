using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TCCExpressMIs.Models
{
    public class EMIContext : DbContext
    {
        private IConfigurationRoot _config;
        public EMIContext(IConfigurationRoot config, DbContextOptions options) :base(options)
        {
            _config = config;
        }

        public DbSet<MoveIn> MoveIns { get; set; }
        public DbSet<Property> Properties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:MS_TableConnectionString"]);
        }
    }
}
