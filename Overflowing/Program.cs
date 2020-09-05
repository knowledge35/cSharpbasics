using System;

namespace overflowing
{
    class Program
    {
        static void Main()
        {
            byte n = 255;
            int z;
            //byte z = n + 1; overflowing
            z = n + 1;
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
