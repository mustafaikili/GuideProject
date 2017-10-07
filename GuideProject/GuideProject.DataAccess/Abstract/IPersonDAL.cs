using GuideProject.Core.DataAccess;
using GuideProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.DataAccess.Abstract
{
    public interface IPersonDAL : IEntityRepository<Persons>
    {
    }
}
