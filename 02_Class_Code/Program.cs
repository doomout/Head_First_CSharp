using System;
using System.Threading;

namespace _02_Class_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OperatorExamples();
            IfEx();
            ForWhileEX();
            TryAnIf();
            TryAnIfElse();
            TrySomeLoops();
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while (count <  10) 
            { 
                count  =  count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count =  count - 1;
            }
            Console.WriteLine("The answer is " +  count);
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 5) 
            { 
                Console.WriteLine("x must be 10"); 
            }
            else
            {
                Console.WriteLine("x isn't 10");
            }
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo  Jr.";
            if ((someValue == 3) && (name == "Joe")) 
            {
                Console.WriteLine("x must  be  10");
            }
            Console.WriteLine("This  line runs  no  name is Joe");
        }

        private static void ForWhileEX()
        {
            int p = 2;
            for (int q = 2; q< 32;  q = q * 2)   //8번 반복
            {
                while(p < q)
                {
                    p = p * 2;  //3번 실행
                    Console.WriteLine(p);
                }
                q = p - q;
            }
        }

        private static void IfEx()
        {
            int someValue = 10;
            string message = "";
            if (someValue > 0)
            {
                message = "Yes, it's 24!";
            }
            if (someValue == 24)
            {
                message = "The vallue  was    24.";
            }
            else
            {
                message = "The  value wasn't  24.";
            }
            Console.WriteLine(message);
        }

        private static void OperatorExamples()
        {
            int width = 3;
            width++;
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);
            while (area < 20)
            {
                height++;
                area  = width * height;
            }
            do
            {
                width--;
                area  = width * height;
            } while (area  > 25);

            string result = "The area";
            result = result + " is  " + area;
            Console.WriteLine(result);
            bool  truthValue = true; 
            Console.WriteLine(truthValue);

           
        }
    }
}
