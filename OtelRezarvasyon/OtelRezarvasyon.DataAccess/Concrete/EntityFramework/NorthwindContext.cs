using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Boss> Bosses { get; set; }
    }
}
