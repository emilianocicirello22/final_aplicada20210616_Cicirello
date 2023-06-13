using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    public abstract class Animales
    {
        private int edad;
        private string nombre;        
        private float peso;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        

        public Animales()
        {
            Console.WriteLine("Ingrese edad");
            this.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso");
            this.peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nombre");
            Nombre = Console.ReadLine();

        }  
        public override string ToString()
        {
            return $"\nPeso: {this.peso} KG\n Nombre:{Nombre}\n";
        }        
    }
}
