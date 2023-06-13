using System;
using System.Collections.Generic;
using System.Text;

namespace parcial
{
    public abstract class Ave : Animales   
    {
        
        public string nom;
        Habitad objhabitad;        


        public Ave()
        {           

            this.objhabitad = new Habitad();
        }

        public override string ToString()
        {
            return $"{base.ToString()} {objhabitad.ToString()}" ;
        }        
    }
}
