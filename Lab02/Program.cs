namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"LVL: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            Console.WriteLine($"HP Percent: {(currentHp * 100) / maxHp}%");
            Console.WriteLine();
            Console.WriteLine($"Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            int myDMG = 60;
            int afterHp = (currentHp - myDMG);
            Console.WriteLine($"HP: {afterHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {(afterHp * 100) / maxHp}%");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // ----------------- Part B ------------------------

            string characterName = "Shusu";
            char characterRank = 'A';
            int characterLevel = 10;
            int characterHp = 100;
            float characterAttack = 12.5f;
            double characterCritRate = 99.9;
            bool isCharacter = true;
            string characterLore = "A former Mars colony structural engineer and sole survivor of the catastrophic collapse of Orbital Station 7. " +
                "Shusu possesses a bionic cybernetic eye and a mechanical arm etched with ancient quantum code. Traversing the galaxy in a retrofitted " +
                "exploration vessel, he searches for the legendary \"Zero Spectrum\"—a primordial energy source rumored to reverse time. Appearing distant " +
                "and cold, he secretly risks his life guiding stranded wanderers across desolate exoplanets, driven by an overwhelming need for redemption.";

            Console.WriteLine($"---------------{characterName}---------------");

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Rank: {characterRank}");
            Console.WriteLine($"LVL: {characterLevel}");
            Console.WriteLine($"HP: {characterHp}");
            Console.WriteLine($"ATK: {characterAttack}");
            Console.WriteLine($"CRT: {characterCritRate}");
            Console.WriteLine();
            Console.WriteLine($"Lore: {characterLore}");
            Console.WriteLine();
            Console.WriteLine($"Character: {isCharacter}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            characterName = "Tutu";
            characterRank = 'C';
            characterLevel = 9;
            characterHp = 90;
            characterAttack = 10.5f;
            characterCritRate = 77.75;
            isCharacter = true;
            characterLore = "A prodigy hacker born in the floating cloud-cities of Jupiter. Tutu can link her consciousness directly into starship neural " +
                "networks without hardware interfaces. Clad in a neon nano-tech suit that morphs and cloaks on command, she is on the run from the Interstellar " +
                "Federation after exfiltrating classified warp-gate blueprints. Using her sharp wit and elite cyber skills, she bypasses high-security systems to" +
                " fund her grand vision: opening an uncharted wormhole to a realm no human has ever witnessed.";


            Console.WriteLine($"---------------{characterName}---------------");

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Rank: {characterRank}");
            Console.WriteLine($"LVL: {characterLevel}");
            Console.WriteLine($"HP: {characterHp}");
            Console.WriteLine($"ATK: {characterAttack}");
            Console.WriteLine($"CRT: {characterCritRate}");
            Console.WriteLine();
            Console.WriteLine($"Lore: {characterLore}");
            Console.WriteLine();
            Console.WriteLine($"Character: {isCharacter}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            characterName = "Wawa";
            characterRank = 'B';
            characterLevel = 16;
            characterHp = 200;
            characterAttack = 5.5f;
            characterCritRate = 50.55;
            isCharacter = true;
            characterLore = "A heavy-combat cyborg hailing from a bleak mining planet. Engineered with hyper-drive steel plating to serve as a living weapon, " +
                "Wawa defected after refusing a ruthless termination command. Beneath his formidable war-machine exterior lies a soul longing for organic life. " +
                "He journeys across galaxies collecting endangered alien flora to cultivate inside his ship's bio-dome. Despite his terrifying battlefield presence, " +
                "his ultimate dream is to terraform an abandoned world into a peaceful, green sanctuary for all lifeforms.";

            Console.WriteLine($"---------------{characterName}---------------");

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Rank: {characterRank}");
            Console.WriteLine($"LVL: {characterLevel}");
            Console.WriteLine($"HP: {characterHp}");
            Console.WriteLine($"ATK: {characterAttack}");
            Console.WriteLine($"CRT: {characterCritRate}");
            Console.WriteLine();
            Console.WriteLine($"Lore: {characterLore}");
            Console.WriteLine();
            Console.WriteLine($"Character: {isCharacter}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            characterName = "Nana";
            characterRank = 'S';
            characterLevel = 20;
            characterHp = 450;
            characterAttack = 16.5f;
            characterCritRate = 50.55;
            isCharacter = true;
            characterLore = "An astro-botanist from the shimmering Stardust Nebula capable of communicating with extraterrestrial flora via neurological frequencies. " +
                "She wears an atmospheric suit equipped with a bio-luminescent capsule capable of instantly healing tissue and repairing damaged cells. " +
                "Travelling between stellar systems, Nana studies unknown ecosystems while actively defending alien worlds from predatory mega-corporations. " +
                "Her warm optimism and quiet courage serve as the emotional anchor, keeping her volatile crew together amidst the void.";

            Console.WriteLine($"---------------{characterName}---------------");

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Rank: {characterRank}");
            Console.WriteLine($"LVL: {characterLevel}");
            Console.WriteLine($"HP: {characterHp}");
            Console.WriteLine($"ATK: {characterAttack}");
            Console.WriteLine($"CRT: {characterCritRate}");
            Console.WriteLine();
            Console.WriteLine($"Lore: {characterLore}");
            Console.WriteLine();
            Console.WriteLine($"Character: {isCharacter}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
