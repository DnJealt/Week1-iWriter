using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Writer
{
    class _420Writer : IWriter
    {
        List<ConsoleColor> BlazeItFaggot = new List<ConsoleColor>();

        public _420Writer()
        {
            BlazeItFaggot.Add(ConsoleColor.Red);
            BlazeItFaggot.Add(ConsoleColor.Yellow);
            BlazeItFaggot.Add(ConsoleColor.Green);
        }


        
      
        public void write(string tekst)
        {
            int listIndex = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                Console.ForegroundColor = BlazeItFaggot[listIndex];
                Console.Write(tekst[i]);
                listIndex++;
                if (listIndex > 2)
                {
                    listIndex = 0;
                }
            }
            Console.WriteLine();                
        }
    }
}
