using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Writer
{
    class RedWriter : IWriter
    {        
        public void write(string tekst)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(tekst);
            Console.ResetColor();
        }
    }
}
