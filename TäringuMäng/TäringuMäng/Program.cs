using System;

namespace TäringuMäng
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd1 = new Random();

            int Plr1 = rnd1.Next(1, 7);

            Random rnd2 = new Random();

            int Plr2 = rnd2.Next(1, 7);

            Console.WriteLine("Mängja 1 viskas täringuga number " + Plr1);
            Console.WriteLine("Mängja 2 viskas täringuga number " + Plr2);

            if (Plr1 < Plr2)
            {
                Console.WriteLine("Mängija 2 võitis");
            }
            else if (Plr1 > Plr2)
            {
                Console.WriteLine("Mängija 1 võitis");
            }
            else
            {
                Console.WriteLine("VIIK!!");
            }
        }
    }
}
