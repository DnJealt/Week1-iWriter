using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Writer
{
    class RainbowWriter : IWriter
    {
        public void write(string tekst)
        {
            List<ConsoleColor> colors = new List<ConsoleColor>();
            colors.Add(ConsoleColor.Cyan);
            colors.Add(ConsoleColor.Magenta);
            colors.Add(ConsoleColor.Red);
            colors.Add(ConsoleColor.Yellow);
            colors.Add(ConsoleColor.Green);

            int iterator = 0;

            for (int i = 0; i < tekst.Length; i++)
            {
                Console.ForegroundColor = colors[iterator];
                Console.Write(tekst[i]);
                if (iterator == colors.Count-1)
                {
                    iterator = 0;
                }
                else
                {
                    iterator++;
                }
            }
            Console.WriteLine();
        }
    }
}
