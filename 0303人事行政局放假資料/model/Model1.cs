using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace _0303人事行政局放假資料.model
{
    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<holiday> Holidays { get; set; }
    }
}