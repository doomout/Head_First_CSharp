using System;
using System.IO;

namespace _10_SwindlerDiabolicalPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter 생성자를 사용해서 파일을 열거나 생성 (파일명 : secret_plan.txt)
            StreamWriter sw = new StreamWriter("secret_plan.txt");

            //파일에 한 줄 씩 쓴다
            sw.WriteLine("How I'll defeat Captain Amazing");
            sw.WriteLine("Another genius secret plan by The Swindler");
            sw.WriteLine("I'll unleash my army of clones upon the citizens of Objectville.");

            string location = "the mall";
            for (int number = 1; number <= 5; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                location = (location == "the mall") ? "downtown" : "the mall";
            }
            //파일 닫기
            sw.Close();
        }
    }
}

/** 파일에 쓰인 내용
How I'll defeat Captain Amazing
Another genius secret plan by The Swindler
I'll unleash my army of clones upon the citizens of Objectville.
Clone #1 attacks the mall
Clone #2 attacks downtown
Clone #3 attacks the mall
Clone #4 attacks downtown
Clone #5 attacks the mall
 */
