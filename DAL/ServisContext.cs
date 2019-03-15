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
    public class ServisContext :IdentityDbContext<Person>
    {  
        public virtual DbSet<Fault> Faults { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}
