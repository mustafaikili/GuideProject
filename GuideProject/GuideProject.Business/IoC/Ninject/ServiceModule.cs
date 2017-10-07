using GuideProject.DataAccess.Abstract;
using GuideProject.DataAccess.Concrete.EntityFramework.DALManagement;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.Business.IoC.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IPersonDAL>().To<EFPersonManagementDAL>();
        }
    }
}
