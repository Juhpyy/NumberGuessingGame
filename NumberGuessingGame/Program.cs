using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int numero = rand.Next(1, 100);
            int arvaus = 0;
            int arvaukset = 1;
            string uudelleen;
            Console.WriteLine("Valitse numero väliltä 1 - 100");

            while (arvaus != numero)
            {
                Console.WriteLine("Arvauksesi: ");
                arvaus = Convert.ToInt32(Console.ReadLine());

                if (arvaus > numero)
                {
                    Console.WriteLine("Numerosi on liian iso!");
                    arvaukset++;
                }

                else if (arvaus < numero)
                {
                    Console.WriteLine("Numerosi on liian pieni!");
                    arvaukset++;
                    
                }

                else {
                    Console.WriteLine($"Arvasit aivan oikein! Arvauksia tarvitsit: {arvaukset}");
                    Console.WriteLine("Haluatko pelata uudelleen? K/E?");
                    uudelleen = Console.ReadLine();
                        if (uudelleen == "K" || uudelleen == "k")
                        {
                            Console.WriteLine("Arvaa uudelleen numero väliltä 1-100");
                            numero = rand.Next(1, 100);
                            arvaukset = 0;
                        }

                        else if (uudelleen == "E" || uudelleen == "e")
                         {
                             Console.WriteLine("Kiitokset pelistä.");
                             Console.ReadLine();
                         }
                }
            }
        }
    }
}
