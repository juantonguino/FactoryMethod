using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.clases
{
    class SedanColombia:Auto
    {
        public SedanColombia()
        {
        }
        public override string getNombre()
        {
            return "Sedan de Colombia";
        }
    }
}
