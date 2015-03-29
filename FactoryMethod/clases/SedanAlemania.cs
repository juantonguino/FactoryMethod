using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.clases
{
    class SedanAlemania:Auto
    {
        public SedanAlemania()
        {
        }
        public override string getNombre()
        {
            return "Sedan de Alemania";
        }
    }
}
