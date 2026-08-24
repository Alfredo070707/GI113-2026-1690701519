namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Dessakon";
            char rank = 'S';
            int level = 1;
            int maxHp = 10000;
            int CurrentHp = 9999;
            float attackPower = 9999.99f;
            double critMultiplier = 9.25;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine();

            int hpPercentage = (CurrentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent : {hpPercentage}%");
            Console.WriteLine();
            Console.WriteLine("Dessakon take 200 damage!");
            CurrentHp = CurrentHp - 200;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP : {CurrentHp}/{maxHp}");
            int newhpPercentage = (CurrentHp * 100) / maxHp;
            Console.WriteLine($"HP Percent : {newhpPercentage}%");
        }
    }
}
