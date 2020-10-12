using System;

namespace juego
{
    class Program
    {
        static void Main(string[] args)
        {
            int monstruo = 10;
            int heroe = 10;

            Random dado = new Random();

            do
            {
                int tirada = dado.Next(1, 10);
                monstruo -= tirada;
                Console.WriteLine($"Monster was damaged and lost {tirada} health and now has {monstruo} health.");

                if (monstruo > 0) continue;

                tirada = dado.Next(1, 10);
                heroe -= tirada;
                Console.WriteLine($"Hero was damaged and lost {tirada} health and now has {heroe} health.");

            } while (heroe > 0 && monstruo > 0); // continuamos hasta que no se cumpla esto

            Console.WriteLine(heroe > monstruo ? "Hero wins!" : "Monster wins!");
        }
    }
}
