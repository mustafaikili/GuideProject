using GuideProject.Business.Abstract;
using GuideProject.DataAccess.Abstract;
using GuideProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.Business.Concrete
{
    public class PersonManagementBLL : IPersonService
    {
        private IPersonDAL _personDAL;
        public PersonManagementBLL(IPersonDAL personDAL)
        {
            _personDAL = personDAL;
        }

        public void Add(Persons person)
        {
            _personDAL.Add(person);
        }

        public ICollection<Persons> GetList()
        {
            return _personDAL.GetAll();
        }

        public Persons GetByID(int? personID)
        {
            return _personDAL.Get(x=>x.PersonID == personID);
        }

        public void Update(Persons person)
        {
            _personDAL.Update(person);
        }
    }
}
