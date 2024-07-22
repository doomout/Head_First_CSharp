using System;
using System.Collections.Generic;
using System.Text.Json;

namespace _10_SerializeGuys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Guy 리스트에 값 2개 입력
            var guys = new List<Guy>()
            {
                new Guy() { Name = "Bob", Clothes = new Outfit() { Top = "t- shirt", Bottom = "jeans"}, Hair = new HairStyle() { Color = HairColor.Red, Length = 3.5f }
                },
                new Guy() { Name = "Joe", Clothes = new Outfit() { Top = "polo", Bottom = "slacks" }, Hair = new HairStyle() { Color = HairColor.Gray, Length = 2.7f }
                },
            };

            //json으로 객체 직렬화 하고 출력
            var jsonString = JsonSerializer.Serialize(guys);
            Console.WriteLine(jsonString);

            //jon을 읽어서 역직렬화 하고 출력
            var copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);
            foreach ( var guy in copyOfGuys )
                Console.WriteLine("I deserialized this guy: {0}", guy);
        }
    }
}

/** 실행 결과 (직렬화)
 [
    {
        "Name":"Bob",
        "Hair":
        {
            "Color":7,
            "Length":3.5
        },
        "Clothes":
        {
            "Top":"t- shirt",
            "Bottom":"jeans"
        }
    },
    {
        "Name":"Joe",
        "Hair":
        {
            "Color":4,
            "Length":2.7
        },
        "Clothes":
        {
            "Top":"polo",
            "Bottom":"slacks"
        }
    }
]

//역직렬화
I deserialized this guy: Bob with 3.5 inch Red hair wearing t- shirt and jeans
I deserialized this guy: Joe with 2.7 inch Gray hair wearing polo and slacks
 */