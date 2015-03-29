using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.clases
{
    class Program
    {
        private static FabricaAutos fabrica;
        static void Main(string[] args)
        {
            Console.WriteLine("patron factory method");
            
            //seleccion de fabrica
            Console.WriteLine("seleccione fabrica");
            Console.WriteLine("1= fabrica colombiana");
            Console.WriteLine("2= fabrica Alemana");
            String texto = Console.ReadLine();

            crearFabrica(int.Parse(texto));

            Console.WriteLine("se ha creado "+fabrica.getNombre());

            //seleccion de auto
            Console.WriteLine("seleccione tipo de auto");
            Console.WriteLine("1= Convetible");
            Console.WriteLine("2= Furgoneta");
            Console.WriteLine("3= Sedan");
            Console.WriteLine("4= Todo Terreno");

            int tipo = int.Parse(Console.ReadLine());

            crearAuto(tipo);
            Console.ReadLine();
        }
        public static void crearAuto(int tipo)
        {
            Auto auto = fabrica.factoryMethod(tipo);
            Console.WriteLine("se ha creado un " + auto.getNombre());
        }

        public static void crearFabrica(int tipoFabrica)
        {
            if (tipoFabrica == 1)
            {
                fabrica = new FabricaAutosColombia();
            }
            else if (tipoFabrica == 2)
            {
                fabrica = new FabricaAutosAlemania();
            }
        }
    }
}
