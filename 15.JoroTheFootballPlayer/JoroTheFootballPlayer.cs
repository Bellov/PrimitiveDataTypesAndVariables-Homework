using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int numberOfHometown = int.Parse(Console.ReadLine());
        double totalPlays = 0;
        totalPlays += numberOfHometown;
        totalPlays += (52 - numberOfHometown) * 2/3;
        totalPlays += numberOfHolidays * 0.5;

        if (leap=="t")
        {
            totalPlays += 3;
        }

        int total = (int)Math.Round(totalPlays);
        Console.WriteLine(total);



    }
}

