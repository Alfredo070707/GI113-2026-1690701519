/*
 * Student ID : 1690701519
 * Name       : Suphakit Kitsupatsakorn
 * Section    : 129A
 * No.        : -
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hungerStat = 100;

            Console.WriteLine("=== DinnerTime ===");
            Console.WriteLine("Now you starving ,need to eat immediately ,but stay calm eat too fast would make you choke");
            Console.WriteLine("Your Hunger: " + hungerStat + "" );
            Console.WriteLine("You need to make hunger stat below 30 in 3 choices but not too low to negative ,you gonna be greedy fat.");
            Console.WriteLine("Caution! : your hunger stat will increase by 10 each turn you need to make a math to finish the meal");
            Console.WriteLine("Okay , let's start the meal!");
            Console.WriteLine();
            Console.WriteLine("=== OnTheTable ===");
            Console.WriteLine("1) FriedChicken | -30 Hunger ");
            Console.WriteLine("2) Pizza | -45 Hunger ");
            Console.WriteLine("3) Milk | -10 Hunger");
            Console.Write("Choose you want to eat first (1-3): ");

            bool firstChoice = int.TryParse(Console.ReadLine(), out int fChoice);

            if (!firstChoice || fChoice < 1 || fChoice > 3)

            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Its not in the choices, you didn't eat anything");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (fChoice == 1)

            {
                hungerStat = hungerStat - 30;
                Console.WriteLine();
                Console.WriteLine("You eat fried chicken like its your last meal on earth ,now your Hunger is " + hungerStat + ".");
                Console.WriteLine();
                Console.WriteLine();

            }

            else if (fChoice == 2)

            {
                hungerStat = hungerStat - 45;
                Console.WriteLine();
                Console.WriteLine("You eat a whole pizza like you never eat that before ,now your Hunger is " + hungerStat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (fChoice == 3)

            {
                hungerStat = hungerStat - 10;
                Console.WriteLine();
                Console.WriteLine("Just why? All of your fav food are already in front of you but you choose milk? ,now your Hunger is " + hungerStat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            hungerStat = hungerStat + 10;
            Console.WriteLine("Hunger increased 10 = " + hungerStat + ".");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=== OnTheTable ===");
            Console.WriteLine("1) CucumberSalad | -20 Hunger ");
            Console.WriteLine("2) Spaghetti | -50 Hunger ");
            Console.WriteLine("3) Soda | -3 Hunger");
            Console.Write("Choose you want to eat next (1-3): ");

            bool secondChoice = int.TryParse(Console.ReadLine(), out int sChoice);

            if (!secondChoice || sChoice < 1 || sChoice > 3)

            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Its not in the choices, you didn't eat anything");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (sChoice == 1)

            {
                hungerStat = hungerStat - 20;
                Console.WriteLine();
                Console.WriteLine("You eat cucumbersalad ,you feel great because you choose healthier ,now your Hunger is " + hungerStat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (sChoice == 2)

            {
                hungerStat = hungerStat - 50;
                Console.WriteLine();
                Console.WriteLine("You eat spaghetti like a black hole that swallow a star ,now your Hunger is " + hungerStat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (sChoice == 3)

            {
                hungerStat = hungerStat - 3;
                Console.WriteLine();
                Console.WriteLine("Okay? its just gas and liquid combined ,now your Hunger is " + hungerStat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            hungerStat = hungerStat + 10;
            Console.WriteLine("Hunger increased 10 = " + hungerStat + ".");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=== OnTheTable ===");
            Console.WriteLine("1) GrilledTurkey | -80 Hunger ");
            Console.WriteLine("2) MushroomSoup | -30 Hunger ");
            Console.WriteLine("3) A knife | ??? Hunger");
            Console.Write("Choose you want to eat next (1-3): ");

            bool thirdChoice = int.TryParse(Console.ReadLine(), out int tChoice);

            if (!thirdChoice || tChoice < 1 || tChoice > 3)

            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Its not in the choices, you didn't eat anything");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (tChoice == 1)

            {
                hungerStat = hungerStat - 80;
                Console.WriteLine();
                Console.WriteLine("You eat juicy turkey from oven ,now your Hunger is " + hungerStat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (tChoice == 2)

            {
                hungerStat = hungerStat - 30;
                Console.WriteLine();
                Console.WriteLine("You eat mushroom soup ,i like mushroom soup too great choice ,now your Hunger is " + hungerStat + ".");
                Console.WriteLine();
                Console.WriteLine();
            }

            else if (tChoice == 3)

            {
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(3000);
                Console.WriteLine("You look to your hands ,it cover of blood and vomit.");
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(3000);
                Console.WriteLine("Your conscious is become fading. ");
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(3000);
                Console.WriteLine("You're dead.");
                Thread.Sleep(10000);
                return;
            }

            Console.WriteLine("=== MealSummary ===");

            if (hungerStat < 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You're greedy fat");
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (hungerStat > 30)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You are still hungry!");
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Great! we've finished the meal, Have a good day!");
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
