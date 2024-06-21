using System;

namespace _06_PigeonAndOstrich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Bird bird;
                Console.Write("\n비둘기의 경우 p를 누르고 타조의 경우 o을 누릅니다: ");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key == 'P') bird = new Pigeon();
                else if (key == 'O') bird = new Ostrich();
                else return;

                Console.Write("\n알을 몇 개 낳아야 할까? ");
                if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
                Egg[] eggs = bird.LayEggs(numberOfEggs);

                foreach (Egg egg in eggs)
                {
                    Console.WriteLine(egg.Description);
                }
            }
        }
    }
}
