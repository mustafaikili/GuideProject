using GuideProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.Model.Mapping.EFMapping
{
    public class AddressesMap : EntityTypeConfiguration<Addresses>
    {
        public AddressesMap()
        {
            //Primary Key
            HasKey(x => x.AddressID);

            //Property

            //ForeignKey
            HasRequired(x => x.Person).WithMany(x => x.Address).HasForeignKey(x => x.PersonID);
        }
    }
}
