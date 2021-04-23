using System;
using System.Collections.Generic;
using System.Text;

namespace AFact.Abstractions
{
    abstract class Animal : IAnimal
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
        public string OwnerName { get; }

        protected readonly Species _species;

        public Species Species => _species;
        public Animal(Species species, string name, DateTime birthDate, string ownerName)
        {
            Name = name;
            BirthDate = birthDate;
            OwnerName = ownerName;
            _species = species;
        }

        public virtual string Speak()
        {
            return "";
        }
    }
}
