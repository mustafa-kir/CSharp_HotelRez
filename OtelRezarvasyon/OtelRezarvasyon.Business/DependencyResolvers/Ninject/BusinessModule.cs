using Ninject.Modules;
using OtelRezarvasyon.Business.Abstract;
using OtelRezarvasyon.Business.Concrete;
using OtelRezarvasyon.DataAccess.Abstract;
using OtelRezarvasyon.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBossService>().To<BossManager>().InSingletonScope();
            Bind<IBossDal>().To<EfBossDal>().InSingletonScope();




        }
    }
}
