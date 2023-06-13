using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    class Paloma:Ave, InterfaceEdad
    {

        public Paloma()
        {

        }

        public string retornarEdad()
        {
            return $"{Edad}";
        }
        
        public override string ToString()
        {
            return $"Paloma\n{base.ToString()}Edad: {retornarEdad()}";
        }


    }
}
