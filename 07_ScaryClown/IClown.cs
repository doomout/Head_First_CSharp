using System;
using System.Collections.Generic;
using System.Text;

namespace _07_ScaryClown
{
    interface IClown
    {
        string FunnyThingIHave {  get; }
        void Honk();
        protected static Random random = new Random(); //ICown이나 이를 상속한 인터페이스만 이 필드에 접근 가능
        private static int carCapacity = 12;
        public static int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if (value > 10)
                    carCapacity = value;
                else
                    Console.Error.WriteLine($"Warning: Car capacity {value} is too small");
            }
        }
        public static string ClownCarDescription()
        {
            return $"A clown car with {random.Next(CarCapacity / 2, carCapacity)} clowns";
        }
    }
}
