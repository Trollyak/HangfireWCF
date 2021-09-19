using HangWCF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangWCF.Jobs
{
    public class IncreaseAgeJob : IInreaceAgeJob
    {

        IPersonService _service;
        public IncreaseAgeJob(IPersonService service)
        {
            _service = service;
        }
        public void IncreaseAgeForEveryone()
        {
            _service.IncreaseAgeForEveryone();
        }
    }
}
