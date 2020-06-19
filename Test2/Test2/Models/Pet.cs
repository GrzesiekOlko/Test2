using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Pet
    {
        public int IdPet { get; set; }

        public string Name{get; set;}

        public bool isMale { get; set; }

        public DateTime DateRegistered { get; set; }

        public DateTime ApprocimateDateOfBirth { get; set; }

        public DateTime? DateAdopted { get; set; }

        public ICollection<BreedType> BreedTypes { get; set;}


    }
}
