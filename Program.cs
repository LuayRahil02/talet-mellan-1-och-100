using System;

namespace talet_mellan_1_och_100_LUAY
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomerare = new Random();
            int hemligt_nummer = randomerare.Next(1, 101);

            Console.WriteLine("Gissa ett tal mellan 1 och 100!");
            string str = Console.ReadLine();
            int tal = Convert.ToInt32(str);
            bool loop = true;
            int f = 0;

            while (loop == true)

            {
                f++;
                if (tal < hemligt_nummer)
                {
                    Console.WriteLine("Gissa på större tal!");
                    str = Console.ReadLine();
                    tal = Convert.ToInt32(str);
                }
                else if (tal > hemligt_nummer)
                {
                    Console.WriteLine("Gissa på ett mindre tal!");
                    str = Console.ReadLine();
                    tal = Convert.ToInt32(str);
                }

                else if (tal == hemligt_nummer)

                {
                    Console.WriteLine("Bra gissat!");
                    Console.WriteLine("Du gjorde det på " + f + " försök");
                    loop = false;

                }

            }

        }
    }
}
