using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    class Perro : Animales, InterfaceEdad
    {        
        
        public string raza;

     

        public Perro()
        {
            Console.WriteLine("Ingrese raza");
            this.raza = Console.ReadLine();
        }     
        public string retornarEdad()
        {
            return $"{Edad * 7}";
        }
        public override string ToString()
        {
            return $"Perro\nRaza: {this.raza}\nEdad: {retornarEdad()}{base.ToString()}";
        }
    }

    
}
