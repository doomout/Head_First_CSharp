using System;
using System.IO;

namespace _10_UseStreamWriterToReadAFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal); //문서 폴더

            var reader = new StreamReader($"{folder}{Path.DirectorySeparatorChar}secret_plan.txt");
            var writer = new StreamWriter($"{folder}{Path.DirectorySeparatorChar}emailToCaptaninA.txt");

            writer.WriteLine("To: CaptainAmazing@objectville.net");
            writer.WriteLine("From: Commissioner@objectville.net");
            writer.WriteLine("Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine("We've discovered the Swindler's terrible plan:");

            while (!reader.EndOfStream) //EndOfStream 속성은 파일에 있는 데이터를 모두 읽어 들이면 true 를 반환한다.
            {
                var lineFromThePlan = reader.ReadLine(); //secret_plan.txt 읽고
                writer.WriteLine($"The plan -> {lineFromThePlan}"); //The plan -> 를 앞에 붙이고 
            }
            writer.WriteLine(); //한줄 떼고
            writer.WriteLine("Can you help us?"); //Can you help us?를 끝에 넣는다.

            writer.Close();
            reader.Close();
        }
    }
}
/**secret_plan.txt 데이터
How I'll defeat Captain Amazing
Another genius secret plan by The Swindler
I'll unleash my army of clones upon the citizens of Objectville.
Clone #1 attacks the mall
Clone #2 attacks downtown
Clone #3 attacks the mall
Clone #4 attacks downtown
Clone #5 attacks the mall 
 */

/**emailToCaptaninA.txt 데이터
To: CaptainAmazing@objectville.net
From: Commissioner@objectville.net
Subject: Can you save the day... again?

We've discovered the Swindler's terrible plan:
The plan -> How I'll defeat Captain Amazing
The plan -> Another genius secret plan by The Swindler
The plan -> I'll unleash my army of clones upon the citizens of Objectville.
The plan -> Clone #1 attacks the mall
The plan -> Clone #2 attacks downtown
The plan -> Clone #3 attacks the mall
The plan -> Clone #4 attacks downtown
The plan -> Clone #5 attacks the mall

Can you help us?
 */