using Repo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Context
{
    public class LearnDB : DbContext
    {

        public DbSet<PERSONCountry> PERSONCountries { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}

