using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Writer
{
    class WriterFactory
    {
        List<IWriter> Writers = new List<IWriter>();

        public IWriter WriterFactory(string writer)
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
            }
        }
    }
}
