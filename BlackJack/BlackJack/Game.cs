using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    abstract class Game : BlackJack.ICommands
    {
        void ICommands.CommandOne()
        {
            Console.WriteLine("Показати всі карти в колоді");
        }
        void ICommands.CommandTwo()
        {
            Console.WriteLine("Перемішати колоду");
        }
        void ICommands.CommandThree()
        {
            Console.WriteLine("Роздати 2 верхні карти з колоди");
        }
    }
}
