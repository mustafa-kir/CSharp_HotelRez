using OtelRezarvasyon.DataAccess.Abstract;
using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DataAccess.Concrete.EntityFramework
{
    public class EfLoginDal:EfEntityRepositoryBase<Login,NorthwindContext>,ILoginDal
    {
    }
}
