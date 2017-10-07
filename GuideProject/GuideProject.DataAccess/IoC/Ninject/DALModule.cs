using GuideProject.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.DataAccess.IoC.Ninject
{
    public class DALModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DbContext>().To<EFDbContext>().InSingletonScope();
        }
    }
}
