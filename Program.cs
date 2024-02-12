using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("EaglesFly");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Eagles");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Fly");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}