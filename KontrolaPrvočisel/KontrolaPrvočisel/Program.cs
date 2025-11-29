using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaPrvočisel
{
    internal class Program
    {
      /*  static void Main(string[] args)
        {
            int cislo = int.Parse(Console.ReadLine());
            bool jeprvocislo = true;

            for (int i = 2; i < cislo; i++)
            {
                if (cislo % i == 0)
                {
                    jeprvocislo = false;
                    //Console.WriteLine($"Číslo {cislo} je dělitelné {i} ");
                    break;
                }
            }

            if (jeprvocislo)
                Console.WriteLine("Číslo je prvnočíslo");
            else Console.WriteLine("Číslo není prvočíslo");

        }*/


        public static bool jePrvocislo(int cislo)
        {
            bool jeprvocislo = true;

            for (int i = 2; i < cislo; i++)
            {
                if (cislo % i == 0)
                {
                    jeprvocislo = false;
                    Console.WriteLine($"Číslo {cislo} je dělitelné {i} ");
                    break;
                }
            }

            if (jeprvocislo)
                return true;
            else return false;

        }

        public static void Rozklad()
        {
            Console.WriteLine("napište celé číslo: ");
            int cislo = int.Parse(Console.ReadLine());

            while (!jePrvocislo(cislo))
            {
                for (int i = 2; i < cislo; i++)
                {
                    if (cislo %i == 0)
                    {
                        Console.WriteLine($"{i}*");
                        cislo /= 1;
                        break;
                    }
                }
            }
            Console.Write(cislo);
            Console.ReadLine();
        }


    }
}

