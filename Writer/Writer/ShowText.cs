using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Writer
{
    class ShowText
    {
        static void Main(string[] args)
        {
            string sampletekst = "abcdefghijklmnopqrstuvwxyz";

            WriterFactory factory = new WriterFactory();
            IWriter writer = factory.Select("red");
            writer.write(sampletekst);



            //
            Console.ReadLine();
        }
    }
}
