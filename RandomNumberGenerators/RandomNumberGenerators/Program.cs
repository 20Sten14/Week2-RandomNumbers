
using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int MyRandomNumber = rnd.Next(1, 11);

            //Programm genereerib juhuslikku nubrit 1 kuni 10 
            //Programm kontrollib, kas genereeritud number on suurem kui, 5
            //Kui number on suurem, kui 5, siis konsool kuvab
            //"Juhuslik number on {MyRandomNumber}, see on suurem kui 5";
            //Juhuslik number on väiksem, kui 5. konsool kuvab
            //Juhuslik number on {MyRandomNumber}, see on väiksem kui 5";
            //Kui number on 5, siis konsool kuvan "juhuslik number on 5"


            if (MyRandomNumber > 5)

            {
                Console.WriteLine("Juhuslik number on " + MyRandomNumber + ",see on suurem kui 5 ");
            }
            else if (MyRandomNumber < 5)
            {
                Console.WriteLine("Juhuslik number on " + MyRandomNumber + ",See on väiksem kui 5 ");
            }
            else
            {
                Console.WriteLine("juhuslik number on");
            }        


        }
    }
}
