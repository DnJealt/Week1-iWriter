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
            _420Writer blazeIt = new _420Writer();
            RedWriter red = new RedWriter();
            rainbow.write(sampletekst);
            blue.write(sampletekst);
            blazeIt.write(sampletekst);
            red.write(sampletekst);



            //
            Console.ReadLine();
        }
    }
}
