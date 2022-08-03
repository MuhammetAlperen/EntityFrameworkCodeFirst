using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirstDeneme.Models;



namespace CodeFirstDeneme.Context
{
    public class MyContext : DbContext
    {
        public MyContext()
             : base("CodeFirstDeneme")
        {
        }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<District> Districts { get; set; }
    }
}
