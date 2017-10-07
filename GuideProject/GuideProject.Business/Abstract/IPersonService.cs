using GuideProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.Business.Abstract
{
    public interface IPersonService
    {
        void Add(Persons person);
        Persons GetByID(int? personID);
        void Update(Persons person);
        ICollection<Persons> GetList();
    }
}
