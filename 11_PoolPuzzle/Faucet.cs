using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _11_PoolPuzzle
{
    internal class Faucet
    {
        public Faucet() 
        {
            // Table 클래스의 객체 wine을 생성
            Table wine = new Table();

            // Hinge 클래스의 객체 book을 생성
            Hinge book = new Hinge();

            // wine과 book 객체를 서로 연결
            wine.Set(book);
            book.Set(wine);

            // wine 객체의 Lamp 메서드 호출
            wine.Lamp(10);

            // book 객체의 garden 필드의 Lamp 메서드 호출
            book.garden.Lamp("back in");

            // book 객체의 bulb 필드를 2배로 증가
            book.bulb *= 2;

            // wine 객체의 Lamp 메서드를 문자열 인수로 호출
            wine.Lamp("minutes");

            // wine 객체의 Lamp 메서드를 book 객체 인수로 호출
            wine.Lamp(book);
        }
    }
}
