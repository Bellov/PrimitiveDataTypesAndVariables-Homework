﻿using System;

//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).


class StringAndObjects
{
    static void Main(string[] args)
    {

        string a = "Hello";
        object b = string.Concat(a, "World");
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.ReadKey();




        //string a = "Hello";
        //string b = "World";
        //string c = a + " " + b;
        //string d = (string)c;
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.WriteLine(d);



        Console.ReadLine();

    }
}

        