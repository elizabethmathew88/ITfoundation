using System;

namespace Homework4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();
            int x = int.Parse(num);
            int i;
            int k;

            for (k = 1; k <=x; k++)
            {
                int fact = 1;
                for (i = 0; i < k; i++)
                {

                    fact = fact * (k - i);
                    
                }
                Console.WriteLine(" {0}! = {1}", k, fact);
            }
            
            Console.ReadLine();
        }
    }
}
