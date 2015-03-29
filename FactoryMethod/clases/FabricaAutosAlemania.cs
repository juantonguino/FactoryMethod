using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.clases
{
    class FabricaAutosAlemania:FabricaAutos
    {
        public FabricaAutosAlemania()
        {
        }
        public override String getNombre()
        {
            return "fabrica Alemana";
        }
        public override Auto factoryMethod(int tipo)
        {
            Auto retorno = null;
            if (tipo == 1)
            {
                retorno = new ConvertibleAlemania();
            }
            else if (tipo == 2)
            {
                retorno = new FurgonetaAlemania();
            }
            else if (tipo == 3)
            {
                retorno = new SedanAlemania();
            }
            else if (tipo == 4)
            {
                retorno = new TodoTerrenoAlemania();
            }
            return retorno;
        }
    }
}
