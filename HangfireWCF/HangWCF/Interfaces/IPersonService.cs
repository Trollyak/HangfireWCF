using HangWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangWCF.Interfaces
{
    public interface IPersonService
    {
        public IEnumerable<Person> GetAllPeoples();
        public void IncreaseAgeForEveryone();

    }
}
