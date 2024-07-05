using System;

namespace _08_Shoes
{
    internal class Program
    {
        //신발장 앱 - a: 신발 추가, r: 신발 삭제

        static ShoeCloset shoeCloset = new ShoeCloset();
        static void Main(string[] args)
        {
            while (true)
            {
                shoeCloset.PrintShoes();
                Console.Write("\nPress 'a' to add 'r' to remove a shoe: ");
                char key = Console.ReadKey().KeyChar;
                switch (key) 
                { 
                    case 'a':
                    case 'A':
                        shoeCloset.AddShoe();
                        break;
                    case 'r':
                    case 'R':
                        shoeCloset.RemoveShoe();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
