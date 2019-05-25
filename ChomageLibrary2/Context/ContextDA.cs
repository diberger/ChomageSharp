using ChomageLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChomageLibrary.Context
{
    public class ContextDA : DbContext
    {
        public ContextDA() : base("name=ChomageSharpDb")
        {
            Database.SetInitializer<ContextDA>(new DropCreateDatabaseAlways<ContextDA>()); // strat 1
            //Database.SetInitializer<ContextDA>(null); // strat 2 => rien faire
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Formation> Formations { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<Postulation> Postulations { get; set; }

        public DbSet<Statut> Statuts { get; set; }
    }
}
