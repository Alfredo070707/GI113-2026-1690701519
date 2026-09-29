/*
 * Student ID : 1690701519
 * Name       : Suphakit Kitsupatsakorn
 * Section    : 129A
 * No.        : -
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hungerStat = 200;
            int targetHunger = 30;

            Console.WriteLine("=== DinnerTime ===");
            Console.WriteLine($"Current Hunger: {hungerStat} | Target: {targetHunger}");
            Console.WriteLine("Try to make your Hunger 30 or below without going negative.");
            Console.WriteLine();

            // Meal 1: Main Course
            Console.WriteLine("--- Meal 1: Main Course ---");
            Console.WriteLine("You are starving and need to eat immediately.");
            Console.WriteLine("[1] Fried Chicken | -80 Hunger");
            Console.WriteLine("[2] Pizza | -30 Hunger");
            Console.WriteLine("[3] Milk | -20 Hunger");
            Console.Write("Choice (1-3): ");

            string input1 = Console.ReadLine();
            bool isValid1 = int.TryParse(input1, out int choice1);

            if (!isValid1 || choice1 < 1 || choice1 > 3)
            {
                Console.WriteLine();
                Console.WriteLine("[Invalid] You did not eat anything.");
            }
            else if (choice1 == 1)
            {
                hungerStat -= 80;
                Console.WriteLine();
                Console.WriteLine("You eat fried chicken like it is your last meal on Earth. (-80)");
            }
            else if (choice1 == 2)
            {
                hungerStat -= 30;
                Console.WriteLine();
                Console.WriteLine("You eat a whole pizza. That should help a lot. (-30)");
            }
            else
            {
                hungerStat -= 20;
                Console.WriteLine();
                Console.WriteLine("You choose milk instead of the food in front of you. (-20)");
            }

            Console.WriteLine($"Current Hunger: {hungerStat}");
            Console.WriteLine();

            // Meal 2: Side Dish
            Console.WriteLine("--- Meal 2: Side Dish ---");
            Console.WriteLine("There are more choices on the table.");
            Console.WriteLine("[1] Cucumber Salad | -70 Hunger");
            Console.WriteLine("[2] Spaghetti | -50 Hunger");
            Console.WriteLine("[3] Soda | -30 Hunger");
            Console.Write("Choice (1-3): ");

            string input2 = Console.ReadLine();
            bool isValid2 = int.TryParse(input2, out int choice2);

            if (!isValid2 || choice2 < 1 || choice2 > 3)
            {
                Console.WriteLine();
                Console.WriteLine("[Invalid] You did not eat anything.");
            }
            else if (choice2 == 1)
            {
                hungerStat -= 70;
                Console.WriteLine();
                Console.WriteLine("You eat cucumber salad. A very healthy choice. (-70)");
            }
            else if (choice2 == 2)
            {
                hungerStat -= 50;
                Console.WriteLine();
                Console.WriteLine("You eat spaghetti like a black hole swallowing a star. (-50)");
            }
            else
            {
                hungerStat -= 30;
                Console.WriteLine();
                Console.WriteLine("You drink soda. It helps a little, but not much. (-30)");
            }

            Console.WriteLine($"Current Hunger: {hungerStat}");
            Console.WriteLine();

            // Meal 3: Final Choice
            Console.WriteLine("--- Meal 3: Final Choice ---");
            Console.WriteLine("You find three final things on the table.");
            Console.WriteLine("[1] Grilled Turkey | -100 Hunger");
            Console.WriteLine("[2] Mushroom Soup | -60 Hunger");
            Console.WriteLine("[3] A Knife | -100 Hunger");
            Console.Write("Choice (1-3): ");

            string input3 = Console.ReadLine();
            bool isValid3 = int.TryParse(input3, out int choice3);

            if (!isValid3 || choice3 < 1 || choice3 > 3)
            {
                Console.WriteLine();
                Console.WriteLine("[Invalid] You did not eat anything.");
            }
            else if (choice3 == 1)
            {
                hungerStat -= 100;
                Console.WriteLine();
                Console.WriteLine("You eat juicy turkey straight from the oven. (-100)");
            }
            else if (choice3 == 2)
            {
                hungerStat -= 60;
                Console.WriteLine();
                Console.WriteLine("You eat mushroom soup. Great choice. (-60)");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You look at your hands. They are covered in blood.");
                Console.WriteLine("You realize that you made a terrible mistake.");
                Console.WriteLine("Your consciousness is fading.");
                Console.WriteLine("You are dead.");
                return;
            }

            // Final Meal Summary
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine($"FINAL HUNGER: {hungerStat} / {targetHunger}");
            Console.WriteLine("==========================================");

            if (hungerStat < 0)
            {
                Console.WriteLine("BAD ENDING");
                Console.WriteLine("You ate too much. Your Hunger went below zero.");
            }
            else if (hungerStat > targetHunger)
            {
                Console.WriteLine("HUNGRY ENDING");
                Console.WriteLine("You are still hungry!");
            }
            else
            {
                Console.WriteLine("GOOD ENDING");
                Console.WriteLine("You finished the meal with a safe Hunger level.");
                Console.WriteLine("Have a good day!");
            }
        }
    }
}