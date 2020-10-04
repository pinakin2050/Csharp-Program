using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqDemo
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }
    class SimpleKeyJoin
    {
        static void Main()
        {
            Person Vansh = new Person() { FirstName = "Vansh", LastName = "Trivedi" };
            Person Ansh = new Person() { FirstName = "Ansh", LastName = "Joshi" };
            Person Daksh = new Person() { FirstName = "Daksh", LastName = "Trivedi" };
            Person Piyu = new Person() { FirstName = "Piyu", LastName = "Dave" };
            Person Nilu = new Person() { FirstName = "Nilu", LastName = "Dave" };
            Person Chaku = new Person() { FirstName = "Chaku", LastName = "Dave" };

            Pet Cat = new Pet() { Name = "Cat", Owner = Vansh };
            Pet Dog = new Pet() { Name = "Dog", Owner = Ansh };
            Pet Parrot = new Pet() { Name = "Parrot", Owner = Daksh };
            Pet Wolf = new Pet() { Name = "Wolf", Owner = Piyu };
            Pet Sparrow = new Pet() { Name = "Sparrow", Owner = Nilu };
            Pet Buffalo = new Pet() { Name = "Buffalo", Owner = Chaku };

            List<Person> People = new List<Person>() { Vansh, Ansh, Daksh, Piyu, Nilu, Chaku };
            List<Pet> Pets = new List<Pet>() { Cat,Dog,Parrot,Wolf,Sparrow,Buffalo};

            var query = from person in People 
                        join pet in Pets on person equals pet.Owner
                        select new {OwnerName = person.FirstName, PetName = pet.Name };

            foreach (var OwnerAndPet in query)
                Console.WriteLine($"\"{OwnerAndPet.PetName}\" is owned by {OwnerAndPet.OwnerName}");
        }
        
    }
}
