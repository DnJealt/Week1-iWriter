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

            RainbowWriter rainbow = new RainbowWriter();
            BlueWriter blue = new BlueWriter();
            rainbow.write(sampletekst);
            blue.write(sampletekst);



            //
            Console.ReadLine();
        }
    }
}
