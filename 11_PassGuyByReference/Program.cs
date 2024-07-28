using System;

namespace _11_PassGuyByReference
{
    internal class Program
    {
        //ref : 메서드에 참조로 인수를 전달하는 방식
        static void ModifyAnIntAndGuy(ref int valueRef, ref Guy guyRef)
        {
            valueRef += 10;
            guyRef.Name = "Bob";
            guyRef.Age = 37;
        }
        static void Main(string[] args)
        {
            var i = 1;
            var guy = new Guy() { Name = "Joe", Age = 26 };
            Console.WriteLine("i is {0} and guy is {1}", i, guy);
            ModifyAnIntAndGuy(ref i, ref guy); //a {Age}-year-old named {Name}
            Console.WriteLine("Now i is {0} and guy is {1}", i, guy);
        }
    }
}
/**실행 결과
i is 1 and guy is a 26-year-old named Joe
Now i is 11 and guy is a 37-year-old named Bob
 */