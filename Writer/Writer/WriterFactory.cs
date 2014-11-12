using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Writer
{
    class WriterFactory
    {

        public IWriter Select(string writer)
        {
            switch (writer)
            {
                case("blue"):
                    return new BlueWriter();
                case ("red"):
                    return new RedWriter();
                case ("420"):
                    return new _420Writer();
                case ("rainbow"):
                    return new RainbowWriter();
                default:
                    return new BlueWriter();
            }
        }
    }
}
