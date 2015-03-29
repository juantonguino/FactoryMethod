using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.clases
{
    class FabricaAutosColombia:FabricaAutos
    {
        public FabricaAutosColombia()
        {
        }
        public override String getNombre()
        {
            return "Fabrica Colombia";
        }
        public override Auto factoryMethod(int tipo)
        {
            Auto retorno = null;
            if (tipo == 1)
            {
                retorno = new ConvertibleColombia();
            }
            else if (tipo == 2)
            {
                retorno = new FurgonetaColombia();
            }
            else if (tipo == 3)
            {
                retorno= new SedanColombia();
            }
            else if (tipo == 4)
            {
                retorno = new TodoTerrenoColombia();
            }
            return retorno;
        }
    }
}
