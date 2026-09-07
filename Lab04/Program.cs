/*
 * Student ID : 1690701519
 * Name       : Suphakit Kitsupatsakorn
 * Section    : 129A
 * No.        : -
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|      NEW ADVENTURE      ");
            Console.WriteLine("+------------------------+");
            Console.Write("Name your hero: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\n\"Welcome, {playerName}. Your journey begins...\"");

            
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|      DIFFICULTY         ");
            Console.WriteLine("+------------------------+");
            Console.Write("Choose difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty set to {difficulty}");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|        ITEM SHOP        ");
            Console.WriteLine("+------------------------+");
            Console.Write("How many items would you like to purchase? ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValidInput}");
            Console.WriteLine($"You have purchased {quantity} items.");
           
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|     RATE THIS LEVEL     ");
            Console.WriteLine("+------------------------+");
            Console.Write("Rate this level (1-5): ");
            bool isValidRating = int.TryParse(Console.ReadLine(), out int rating);
            Console.WriteLine("Valid rating: " + isValidRating);
            Console.WriteLine($"You have rated this level {rating}/5.");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|     CHARACTER CREATION  ");
            Console.WriteLine("+------------------------+");
            Console.Write("Name your character: ");
            string CharacterName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool isValidClass = int.TryParse(Console.ReadLine(), out int classNum);
            Console.WriteLine("Starting luck (1.0 - 10.0) ");
            bool isValidLuck = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"Character Name: {CharacterName}, Class: {classNum}, Luck: {luck}");
        }
    }
}