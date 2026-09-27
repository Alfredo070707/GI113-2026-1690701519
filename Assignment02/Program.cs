/*
 * Student ID : 1690701519
 * Name       : Suphakit Kitsupatsakorn
 * Section    : 129A
 * No.        : -
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialOre = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--     Welcome to The Forge      --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialOre} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu : ");
            char chosenMenu;
            bool chosenValid = char.TryParse(Console.ReadLine(), out chosenMenu);

            Console.Write("=> How much would you like : ");
            double amount;
            bool amountValid = double.TryParse(Console.ReadLine(), out amount);

            if (amountValid && amount > 0 && amount <= MaxBatch)
            {
                if (chosenValid)
                {
                    if (chosenMenu == 'S' || chosenMenu == 's')
                    {
                        double ingotAmount = amount * SmeltRate;
                        Console.WriteLine(
                            $"=> {amount:F2} {MaterialOre} Ore = {ingotAmount:F2} {MaterialOre} Ingot");
                    }
                    else if (chosenMenu == 'B' || chosenMenu == 'b')
                    {
                        double oreAmount = amount / SalvageRate;

                        Console.WriteLine($"=> {amount:F2} {MaterialOre} Ingot = {oreAmount:F2} {MaterialOre} Ore");

                    }
                    else
                    {
                        Console.WriteLine("Error : Invalid menu");
                    }
                }
                else
                {
                    Console.WriteLine("Error : Invalid menu");
                }

            }
            else
            {
                Console.WriteLine("Error : Invalid amount");
            }

        }
    }
}

/* อันนี้ผมทำผิด เเต่ไม่อยากลบ ขออณุยาตวางใว้ดูเล่นเป็นความภูมิใจนะครับ
  
                        Console.Write("=> Chose Menu : ");
                        char chosenMenu;
                        bool chosenValid = char.TryParse(Console.ReadLine(), out chosenMenu);

                        if (chosenValid)
                        {
                            if (chosenMenu == 'S' || chosenMenu == 's')
                            {
                                chosenMenu = 'S';
                            }
                            else if (chosenMenu == 'B' || chosenMenu == 'b')
                            {
                                chosenMenu = 'B';
                            }
                            else
                            {
                                Console.WriteLine("Error : Invalid. Please type 'S' or 'B' ");
                                return;
                            }
                        }

                        Console.Write("=> How much would you like : ");
                        double amount;
                        bool amountValid = double.TryParse(Console.ReadLine(), out amount);

                        if (!amountValid)
                        {
                            Console.WriteLine("Error : Invalid. Please type number");
                            return;
                        }

                        if (amountValid && amount > 0 && amount <= MaxBatch)
                        {
                            if (chosenMenu == 'S')
                            {
                                double ingotAmount = amount * SmeltRate;
                                Console.WriteLine($"=> {amount:F2} {MaterialOre} Ore = {ingotAmount:F2} {MaterialOre} Ingot");
                            }
                            else if (chosenMenu == 'B')
                            {
                                double oreAmount = amount / SalvageRate;

                                Console.WriteLine($"=> {amount:F2} {MaterialOre} Ingot = {oreAmount:F2} {MaterialOre} Ore");

                            }
                        }
*/