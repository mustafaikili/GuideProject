using GuideProject.Core.DataAccess.EntityFramework;
using GuideProject.DataAccess.Abstract;
using GuideProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.DataAccess.Concrete.EntityFramework.DALManagement
{
    public class EFPersonManagementDAL: EFEntityRepositoryBase<EFDbContext,Persons>,IPersonDAL
    {
    }
}
