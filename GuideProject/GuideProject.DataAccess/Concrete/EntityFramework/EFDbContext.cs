using GuideProject.Model.Entities;
using GuideProject.Model.Mapping.EFMapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideProject.DataAccess.Concrete.EntityFramework
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("Server=.;Database=GuideProject;Integrated Security=True;")
        {
            Database.SetInitializer(new DatabaseCreated());
        }
        public DbSet<Addresses> Address { get; set; }
        public DbSet<Persons> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressesMap());
            modelBuilder.Configurations.Add(new PersonsMap());
        }
        public class DatabaseCreated : CreateDatabaseIfNotExists<EFDbContext>
        {
            protected override void Seed(EFDbContext context)
            {
                for (int i = 0; i < 10; i++)
                {
                    Persons person = new Persons();
                    person.PersonName = FakeData.NameData.GetFirstName();
                    person.PersonLastName = FakeData.NameData.GetSurname();
                    person.PersonAge = FakeData.NumberData.GetNumber(0, 100);

                    //Addresses address = new Addresses();
                    //address.AddressDescription = FakeData.PlaceData.GetAddress();
                    

                    context.Person.Add(person);
                    //context.Address.Add(address);
                }
                context.SaveChanges();
            }
        }
    }
}
