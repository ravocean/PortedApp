using System;

namespace PortedApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Pets dog = new Pets();

            dog.SetName("Olive");
            dog.Sound = "Woof!";

            Console.WriteLine("The dog's name is {0} and {0} says {1}",
                dog.GetName(), dog.Sound);

            // Check auto-generated getters and setters
            dog.PetOwner = "Zack";

            Console.WriteLine("{0}'s owner is {1}",
                dog.GetName(), dog.PetOwner);

            Console.WriteLine("{0}'s shelter ID is {1}",
                dog.GetName(), dog.idNum);

            // Create another animal to check the NumOfPets
            Pets monkey = new Pets("Marcel", "Ooh-ooh, ah-ah!");

            // Check the number of pets
            Console.WriteLine("Number of pets: {0}",
                Pets.NumOfPets);

            Console.ReadLine();
        }
    }
}
