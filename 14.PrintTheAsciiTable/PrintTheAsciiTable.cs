using System;

//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently. You may need to use for-loops (learn in Internet how).

//class PrintTheAsciiTable
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        for (int i = 0; i < 256; i++)
//        {
//            Console.Write((char)i+ " ");
//        }
//        Console.ReadLine();
//    }
//}

using System;
class ASCII
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ushort a = 0;
        ushort b = 256;
        while (a < b)
        {
            Console.WriteLine("Decimal Number: {0}, and ASCII Code: {1}", a, (char)a);
            a++;
        }

    }
}