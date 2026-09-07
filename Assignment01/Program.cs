/*
 * Student ID : 1690701519
 * Name       : Suphakit Kitsupatsakorn
 * Section    : 129A
 * No.        : -
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CardName = "Devil Fruit Card";
            var fruitName = "Mere Mera";
            var fruitType = "Logia";
            string fruitAbility = "Allows user to control flames.";
            char rarityTier = 'A';
            int level = 153;
            float fruitEnergy = 350.75f;
            double fruitPower = 149.75;
            bool isAwakened = true;

            double levelDouble = level;
            int powerTruncated = (int)fruitPower;
            int powerRounded = Convert.ToInt32(fruitPower);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"I         {CardName}        I");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("I             @___                I");
            Console.WriteLine("I               __I_              I");
            Console.WriteLine("I           _--      --_          I");
            Console.WriteLine("I          ' @    @    @'         I");
            Console.WriteLine(@"I          \    @    @  /         I");
            Console.WriteLine(@"I           \ @     @  /          I");
            Console.WriteLine(@"I            \    @   /           I");
            Console.WriteLine("I              ------             I");
            Console.WriteLine($"I       {fruitName} : {fruitType,-14}I");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("I             Ability             I");
            Console.WriteLine("I                                 I");
            Console.WriteLine($"I  {fruitAbility,-31}I");
            Console.WriteLine("I                                 I");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("I                                 I");
            Console.WriteLine($"I  LVL         : {level,-17}I");
            Console.WriteLine($"I  Rarity      : {rarityTier,-17}I");
            Console.WriteLine($"I  Power       : {fruitPower,-17}I");
            Console.WriteLine($"I  Energy      : {fruitEnergy,-17}I");                          
            Console.WriteLine($"I  Awaken      : {isAwakened,-17}I");
            Console.WriteLine("I                                 I");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("I             Log                 I");
            Console.WriteLine("I                                 I");
            Console.WriteLine($"I  Lv as double  : {levelDouble,-15}I");
            Console.WriteLine($"I  Power (cast)  : {powerTruncated,-15}I");
            Console.WriteLine($"I  Power Convert : {powerRounded,-15}I");
            Console.WriteLine("I                                 I");
            Console.WriteLine("-----------------------------------");
        }
    }
}





          