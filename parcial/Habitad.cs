using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    class Habitad
    {
        private string continente;
        private bool terrestre = false;
        private bool maritimo = false;
        private bool anfibio = false;

        public Habitad()
        {
            Console.WriteLine("de que continente es el ave");
            this.continente = Console.ReadLine();

            int opc = 0;
            
            do
            {
                Console.WriteLine("Ingrese si el ave es:\n1-Terrestre\n2-Marino\n3-Anfibio");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1 :
                        this.terrestre = true;
                        break;
                    case 2:
                        this.maritimo = true;
                        break;
                    case 3:
                        this.anfibio = true;
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

            } while (opc == 1 && opc == 2 && opc == 3);
        }

        public override string ToString()
        {
            string mensaje="";
            if(this.terrestre){
                mensaje = "Ave terrestre";
            }else if (this.maritimo)
            {
                mensaje = "Ave maritima";
            }
            else if (this.anfibio)
            {
                mensaje = "Ave anfibia";
            }

            return $"El ave se encuentra en {this.continente} y es un {mensaje}";
        }
    }
}
