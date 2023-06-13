using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    class Pinguino : Ave
    {
        public Pinguino()
        {

        }
        public string retornarEdad()
        {
            return $"{Edad * 5}";
        }
        
        public override string ToString()
        {
            return $"Pinguino\n{base.ToString()}\nEdad: {retornarEdad()}";
        }
    }
}

