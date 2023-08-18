using CapturaDeProspectos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectosCaptura
{
    internal class DataBaseContext : DbContext
    {
        public DbSet<Prospecto> Prospectos { get; set; }

        private static DataBaseContext context;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public static DataBaseContext GetContext()
        {
            if (context == null)
            {
                context = new DataBaseContext();
            }

            return context;
        }

    }
}
