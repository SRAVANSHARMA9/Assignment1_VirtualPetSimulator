using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetSimulator
{
    public class VirtualPet
    {
        // Properties
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }


        // Constructors

        public VirtualPet(string PetName)
        {
            Name = PetName;
            Hunger = 5;
            Happiness = 5;
            Health = 5;

        }

        public void FeedPet()
        {
            Hunger = --Hunger;
            Health = ++Health;
            Console.WriteLine($"You fed  {Name}.His Hunger decreases, and Health increases.");
        }

        public void PlayWithPet()
        {
            Hunger = ++Hunger;
            Happiness = ++Happiness;
            Console.WriteLine($"You played with {Name}.His Hunger increases, and happiness increases.");

        }

        public void RestThePet()
        {
            Happiness = --Happiness;
            Health = ++Health;
            Console.WriteLine($"You let the  {Name} rest.His Health increases and happiness decreases.");

        }

        public void DefaultVal()
        {


            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Happiness: {Happiness}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine();
        }



    }

}