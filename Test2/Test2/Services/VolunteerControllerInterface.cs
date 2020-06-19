using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models;

namespace Test2.Services
{
    interface VolunteerControllerInterface
    {

        Volunteer GetVolunteer(DateTime startingDate);
    }
}
