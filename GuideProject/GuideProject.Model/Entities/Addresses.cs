using GuideProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.Model.Entities
{
    public class Addresses : IEntity
    {
        public int AddressID { get; set; }
        public int? PersonID { get; set; }
        public string AddressDescription { get; set; }

        //Navigation Property
        public Persons Person { get; set; }

    }
}
