using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClasePerro
    {
        public String nombre { get; set; }
        public int Edad { get; set; }

        public ClasePerro(String _nombre, int _edad)
        {
            this.nombre = _nombre;
            this.Edad = _edad;
        }

        public void ladrar()
        {
            Console.WriteLine("ladro");
        }


    }
}
