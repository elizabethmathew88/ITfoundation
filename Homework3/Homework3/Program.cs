using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the no of seconds");
        string seconds = Console.ReadLine();
        int sec = int.Parse(seconds);

        int days = 0;
        int hours = 0;
        int mins = 0;
        

        int secperday = 86400;
        int secperhour = 3600;
        int secpermin = 60;

        int secrem = sec;
        while (secrem >= secperday)
        {
            days++;
            secrem = secrem - secperday;
        }
        while (secrem >= secperhour)
        {
            hours++;
            secrem = secrem - secperhour;
        }
        while (secrem >= secpermin)
        {
            mins++;
            secrem = secrem - secpermin;
        }


        Console.WriteLine("{0}days {1}hours {2}mins {3}seconds", days, hours, mins, secrem);
        Console.ReadLine();

    }
}
