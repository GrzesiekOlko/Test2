using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models;

namespace Test2.Services
{
    public class VolunteerService : VolunteerControllerInterface

    {
        private readonly VolunteerDbContext _context;
        public VolunteerService(VolunteerDbContext context) { 
        
        }
        public Volunteer GetVolunteer(DateTime startingDate)
        {
           var x =  _context.Volunteers.Where(n1 => n1.StartingDate == startingDate);

            return x;
        }
    }
}
