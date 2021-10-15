using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortedApp
{
    class Pets
    {

        private string name;
        private string sound;

        public const string SHELTER = "Animal Shelter";

        public readonly int idNum;

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        // Define constructors
        public Pets()
            : this("No Name", "No Sound") { }

        public Pets(string name)
            : this(name, "No Sound") { }

        public Pets(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfPets = 1;

            Random random = new Random();
            idNum = random.Next(1, 10000);
        }

        // Define setters
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            } else
            {
                this.name = "No Name";
                Console.WriteLine("Name cannot contain numbers");
            }
        }

        // Define getter
        public string GetName()
        {
            return name;
        }

        // Properties
        public string Sound
        {
            get { return sound; }
            set
            {
                if(value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                sound = value;
            }
        }

        public string PetOwner { get; set; } = "No Pet Owner";

        public static int numOfPets = 0;

        public static int NumOfPets
        {
            get { return numOfPets; }
            set { numOfPets += value; }
        }

    } // end of Pets class
}
