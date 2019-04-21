using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterforHomeless_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter<Dog> shelter = new AnimalShelter<Dog>();
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());

            Dog d = shelter.Release(1);

            AnimalShelter<Cat> shelter2 = new AnimalShelter<Cat>();
            shelter2.Shelter(new Cat());
            shelter2.Shelter(new Cat());

            Cat cat = shelter2.Release(1);
            Console.ReadLine();



        }
    }
}
