using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SoccerTeam.Models
{
    public partial class datacontext : DbContext
    {
        public datacontext()
            : base("name=datacontext")
        {
        }

        public virtual DbSet<Player> Players { set; get; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
