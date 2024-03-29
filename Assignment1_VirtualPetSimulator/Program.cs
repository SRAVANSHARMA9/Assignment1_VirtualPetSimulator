﻿using System;
using System.Collections.Generic;

namespace VirtualPetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Choosing pet type
            Console.WriteLine("Please choose a type of pet");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            Console.WriteLine("");

            Console.WriteLine("Enter User input below: \n");

            //Storing the input which users enter.
            int PetTypeSel = Convert.ToInt32(Console.ReadLine());

            //Displaying the type of pet user selected.
            switch (PetTypeSel)
            {
                case 1:
                    Console.WriteLine("\nYou've chosen a Cat. What would you like to name your Cat?");
                    break;

                case 2:
                    Console.WriteLine("\nYou've chosen a Dog. What would you like to name your Dog?");
                    break;

                case 3:
                    Console.WriteLine("\nYou've chosen a Rabbit. What would you like to name your Rabbit?");
                    break;

                default:
                    Console.WriteLine("\nPlease enter the input as 1 or 2 or 3 only.");
                    break;
            }

            Console.WriteLine("\nEnter User input below: \n");

            //Creating a variable for user's pet name.
            String PetName = Console.ReadLine();

            //Creating the virtual pet.
            VirtualPet PetDet = new VirtualPet(PetName);

            Console.WriteLine("\nWelcome, " + PetName + "!. Lets take good care of you.");

            //Creating main menu.
            bool UserPetFunctionSelection = true;

            while (UserPetFunctionSelection)
            {
                Console.WriteLine("\nMain Menu \n");
                Console.WriteLine("1. Feed " + PetName);
                Console.WriteLine("2. Play with " + PetName);
                Console.WriteLine("3. Let " + PetName + " rest");
                Console.WriteLine("4. Check " + PetName + "'s status");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\nEnter User input below: \n");
                int MainMenuSel = Convert.ToInt32(Console.ReadLine());

                switch (MainMenuSel)
                {
                    case 1:
                        //Feeding the pet.
                        PetDet.FeedPet();
                        break;

                    case 2:
                        //Playing with the pet.
                        PetDet.PlayWithPet();
                        break;

                    case 3:
                        //Giving rest to the pet.
                        PetDet.RestThePet();
                        break;

                    case 4:
                        //Displaying the default values of pet status.
                        PetDet.DefaultVal();
                        break;

                    case 5:
                        //set UserPetFunctionSelection to false and program exits
                        UserPetFunctionSelection = false;
                        Console.WriteLine("\nThank you so much for playing the game.");
                        break;

                    default:
                        break;

                }

            }

        }

    }

}