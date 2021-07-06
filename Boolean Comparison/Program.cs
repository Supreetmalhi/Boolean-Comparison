using System;

namespace Boolean_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Loop Example");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("Do While Loop Example");
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);
        }
    }
}
