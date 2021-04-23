using AFact.Abstractions;
using AFact.Registration;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();

            catalog.RegisterAnimal("Fluffy", new DateTime(2015, 02, 02), Species.Cat, "John Smith");
            catalog.RegisterAnimal("Spikey", new DateTime(2015, 03, 03), Species.Dog, "Jane Smith");
            catalog.RegisterAnimal("Mr Pig", new DateTime(2015, 03, 03), Species.ManBearPig, "Mr Smith");

            catalog.RecordAll();
        }
    }
}
