using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    class By
    {
        public void SayBy()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(10, 10);
            Console.Write("say goodbye");
        }
    }
}