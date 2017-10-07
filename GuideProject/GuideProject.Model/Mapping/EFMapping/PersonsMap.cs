using GuideProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.Model.Mapping.EFMapping
{
    public class PersonsMap : EntityTypeConfiguration<Persons>
    {
        public PersonsMap()
        {
            //Primary Key
            HasKey(x => x.PersonID);

            //Property

        }
    }
}
