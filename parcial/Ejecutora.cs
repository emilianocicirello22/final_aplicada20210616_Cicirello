using System;
using System.Collections.Generic;

namespace parcial
{
    class Ejecutora
    {
        static void Main(string[] args)
        {
            List<Animales> lista = new List<Animales>();
            int opc = 0;



            do
            {
                Console.WriteLine("1-Para crear un perro\n2-Para crear un pinguino\n3-Para crear una paloma\n4-Mostrar datos de animales");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        lista.Add(new Perro());
                        break;
                    case 2:
                        lista.Add(new Pinguino());
                        break;
                    case 3:
                        lista.Add(new Paloma());
                        break;
                    case 4:
                        MostrarDatos(lista);
                        break;

                }


            } while (opc != 0);            

        }

        public static void MostrarDatos(List<Animales> li)
        {            
            
            foreach(Animales lista in li)
            {
                Console.WriteLine(lista);
            }
        } 
    }
}
