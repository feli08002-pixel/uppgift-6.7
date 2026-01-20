using System;

namespace Uppgift6_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(ÄrPrimtal(23));
            Console.WriteLine(ÄrPrimtal(20));
        }

        static bool ÄrPrimtal(int tal)
        {
            if (tal < 2) return false;
            for (int i = 2; i < tal; i++)
                if (tal % i == 0)
                    return false;
            return true;
        }
    }
}




