using System;
using System.IO;

namespace _10_HexDump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var position = 0;
            //textdata.txt는 bin\Debug\netcoreapp3.1\ 폴더에 미리 저장, 내용은 Elementary, my dear Watson!
            using (var reader = new StreamReader("textdata.txt"))
            {
                //reader.EndOfStream 는 파일에서 아직 읽어 올 문자가 남아 있을 경우 false 반환
                while (!reader.EndOfStream)
                {
                    //파일에서 다음 16바이트를 읽어 바이트 배열에 저장
                    var buffer = new char[16];
                    var bytesRead = reader.ReadBlock(buffer, 0, 16);

                    //현재 위치를 16진수로 출력하고, 콜론과 공백 문자를 출력
                    Console.Write("{0:x4}: ", position);
                    position += bytesRead;

                    //바이트 배열에 있는 문자 각각에 해당하는 16진수 값을 출력
                    for (int i = 0; i < 16; i++) 
                    { 
                        if(i < bytesRead)
                            Console.Write("{0:x2} ", (byte)buffer[i]);
                        else 
                            Console.Write(" ");
                        if (i == 7) 
                            Console.Write("-- ");
                    }
                    //바이트 배열에 있는 실제 문자를 출력
                    var bufferContents = new string(buffer);
                    Console.WriteLine(" {0}", bufferContents.Substring(0, bytesRead));
                }
            }
        }
    }
}

/** 실행결과
0000: 45 6c 65 6d 65 6e 74 61 -- 72 79 2c 20 6d 79 20 64  Elementary, my d
0010: 65 61 72 20 57 61 74 73 -- 6f 6e 21       ear Watson!
 */