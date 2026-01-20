using System;

namespace Uppgifter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(AntalTalIText("5 4,1 hej 9,04"));
        }

        static int AntalTalIText(string text)
        {
            string[] delar = text.Split(' ');
            int antal = 0;

            foreach (string d in delar)
                if (double.TryParse(d, out _))
                    antal++;

            return antal;
        }
    }
}



