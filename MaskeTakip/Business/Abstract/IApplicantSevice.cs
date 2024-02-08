using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantSevice
    {
        public void ApplyForMask(Person person);
        List<Person> GetList();
        public bool CheckPerson(Person person);

    }
}
