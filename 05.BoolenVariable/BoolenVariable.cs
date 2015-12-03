using System;

//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. Print it on the console.


class BoolenVariable
{
    static void Main()
    {
        bool isFemale = false;
        Console.Write("Are you female? (yes/no): ");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            isFemale = true;
            Console.WriteLine(isFemale);
        }

        else if (answer=="no")
        {
            isFemale = false;
            Console.WriteLine(isFemale);

        }

        else
        {
            Console.WriteLine("Invalid Input");
        }


        Console.ReadLine();
        
    }
}

