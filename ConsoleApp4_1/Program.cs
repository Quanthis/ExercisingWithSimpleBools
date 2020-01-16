using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wiek, PLN;
            bool kino;
            Console.WriteLine("How old are you?");
            wiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much money you got?");
            PLN = Convert.ToInt32(Console.ReadLine());
            kino = (wiek >= 18 && PLN >= 20);
            Console.WriteLine(kino);
            Console.ReadKey();
        }
    }
}
