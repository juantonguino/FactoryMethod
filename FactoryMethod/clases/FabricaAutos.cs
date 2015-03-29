using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.clases
{
    abstract class FabricaAutos
    {
        public abstract String getNombre();
        public abstract Auto factoryMethod(int tipo);
    }
}
