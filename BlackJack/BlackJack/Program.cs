using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Cards cr = new Cards();
            Console.ForegroundColor = ConsoleColor.Green;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cr.OutCards(number));
            Console.ReadKey();
        }
    }
}
