using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.clases
{
    class TodoTerrenoAlemania:Auto
    {
        public TodoTerrenoAlemania()
        {
        }
        public override string getNombre()
        {
            return "todo terreno de Alemania";
        }
    }
}
