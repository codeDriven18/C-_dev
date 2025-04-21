using System;

namespace Def
{
    class Program
    {
        static void Main()
        {
            int num_1 = 0,
                num_2 = 0;

            num_1 = Convert.ToInt32(Console.ReadLine());
            num_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("first: " + num_1 + ". second: " + num_2);
        }
    }
}
