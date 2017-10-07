using GuideProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.Model.Entities
{
    public class Persons: IEntity
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string PersonLastName { get; set; }
        public int PersonAge { get; set; }

        //Navigation Property

        public virtual ICollection<Addresses> Address { get; set; }
    }
}
