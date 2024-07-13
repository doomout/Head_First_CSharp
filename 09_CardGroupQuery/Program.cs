using System;
using System.Linq;

namespace _09_CardGroupQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck()
                .Shuffle() //랜덤하게 섞는다.
                .Take(16); //앞에서 16장의 카드를 반환
            var grouped = 
                from card in deck
                //group : 그룹화 요소를 알려줌, by : 그 그룹을 결정하는 조건, into : 다른절에서 그룹을 참조할 때 사용할 수 있는 새 변수 선언
                group card by card.Suit into suitGroup
                orderby suitGroup.Key descending
                select suitGroup;

            foreach (var group in grouped) 
            {
                //무늬를 기준으로 그룹화, 갯수, 최소값, 최대값 출력
                Console.WriteLine($@"Group: {group.Key},   Count: {group.Count()},   Minimum: {group.Min()},  Maximum: {group.Max()}");
            }
        }
    }
}
