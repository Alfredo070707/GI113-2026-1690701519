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
            Console.WriteLine("|   CHARACTER CREATION    ");
            Console.WriteLine("+------------------------+");
            Console.Write("Name your character: ");
            string CharacterName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool isValidClass = int.TryParse(Console.ReadLine(), out int classNum);
            Console.WriteLine("Starting luck (1.0 - 10.0) ");
            bool isValidLuck = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"Character Name: {CharacterName}, Class: {classNum}, Luck: {luck}");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|        ITEM SHOP        ");
            Console.WriteLine("+------------------------+");
            Console.Write("How many items would you like to purchase? ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValidInput}");
            Console.WriteLine($"You have purchased {quantity} items.");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|        SET VOLUME       ");
            Console.WriteLine("+------------------------+");
            Console.Write("Set your mic volume(0.0-1.0): ");
            bool isValidVolume = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {isValidVolume}");
            Console.WriteLine($"Volume set to: {volume}");

            Console.WriteLine("+------------------------+");
            Console.WriteLine("|      NEW SAVE FILE      ");
            Console.WriteLine("+------------------------+");
            Console.Write("Name your save file: ");
            string SaveName = Console.ReadLine();
            Console.Write("Save slot (1-3): ");
            bool isValidSlot = int.TryParse(Console.ReadLine(), out int slotNum);
            Console.WriteLine($"Done! ,you have saved \"{SaveName}\" on slot {slotNum}");
            Console.WriteLine($"Valid input: {isValidSlot}");
         
        }
    }
}