using AFact.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFact.Registration
{
    class Catalog
    {
        private readonly List<Animal> _animals;
        private readonly AnimalFactory _animalFactory;
        private readonly VoiceRecorder _voiceRecorder;
        public Catalog()
        {
            _animals = new List<Animal>();
            _animalFactory = new AnimalFactory();
            _voiceRecorder = new VoiceRecorder();
        }

        public void RecordAll() 
        {
            foreach (var a in _animals)
            {
                _voiceRecorder.Record(a);
            }
        }
        public void RegisterAnimal(string name, DateTime birthDate, Species species, string ownerName)
        {
            /*
            Animal a = null;

            switch (species)
            {
                case Species.Cat:
                    {
                        a = new Cat(name, birthDate, ownerName);
                        break;
                    }
                case Species.Dog:
                    {
                        a = new Dog(name, birthDate, ownerName);
                        break;
                    }
            }
            */

            Animal a = _animalFactory.Create(species, name, birthDate, ownerName);
            _animals.Add(a);
        }
    }
}
