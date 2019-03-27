using Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServisContext : IdentityDbContext<Person>
    {
        public ServisContext():base ("ServisContext")
        {
          
        }
        public virtual DbSet<LiveMessage> LiveMessages { get; set; }
        public virtual DbSet<Fault> Faults { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LiveMessage>().HasKey(x => x.Id);
            modelBuilder.Entity<Fault>().HasKey(x => x.Id);

            modelBuilder.Entity<Person>().HasMany(x => x.Faults);

            base.OnModelCreating(modelBuilder);
        }
    }
}
