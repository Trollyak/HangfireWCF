using HangWCF.Interfaces;
using HangWCF.Models;
using HangWCF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangWCF.Services
{
    public class PersonService : IPersonService
    {
        PersonContext _context = new PersonContext();
        public IEnumerable<Person> GetAllPeoples()
        {
            return _context.Persons.ToList();
        }
        public void IncreaseAgeForEveryone()
        {
            IEnumerable<Person> persons = GetAllPeoples();
            persons.ToList().ForEach(x => x.AgeInDays++);
            _context.SaveChanges();
        }
    }
}
