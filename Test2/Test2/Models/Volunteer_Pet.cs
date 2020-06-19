using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Volunteer_Pet
    {
        public DateTime DateAccepted { get; set;}

        public ICollection<Volunteer> volunteers { get; set;}

        public ICollection<Pet> pets { get; set; }
    }
}
