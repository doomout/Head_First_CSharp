using System;

namespace _06_WeaponDamage_Part_1
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            SwordDamage sd = new SwordDamage(RollDice(3));
            ArrowDamage ad = new ArrowDamage(RollDice(1));

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit : ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                Console.Write("\nS for sword, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch (weaponKey)
                {
                    case 'S':
                        //칼 데미지 계산
                        sd.Roll = RollDice(3);
                        sd.Magic = (key == '1' || key == '3');
                        sd.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"\nRolled {sd.Roll}  for  {sd.Damage} HP\n");
                        break;
                    case 'A':
                        //화살 데미지 계산
                        ad.Roll = RollDice(1);
                        ad.Magic = (key == '1' || key == '3');
                        ad.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"\nRolled {ad.Roll}  for  {ad.Damage} HP\n");
                        break;
                    default:
                        return;
                }
            }
        }

        private static int RollDice(int numberOfRolls)
        {
            int total = 0;
            for (int i = 0; i< numberOfRolls; i++)
            {
                total += random.Next(1, 7);
            }
            return total;
        }
    }
}
