using HangWCF.Models;
using System.Data.Entity;

namespace HangWCF.Repository
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("MainBase")
        {

        }
        public DbSet<Person> Persons { get; set; }

    }
}