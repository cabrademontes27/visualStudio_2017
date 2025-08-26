using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("aqui si lo imprime");
            for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine("Hola dentro del for");
            }

            ClasePerro clasePerro = new ClasePerro("Jose", 15);
            clasePerro.ladrar();
        }
    }
}
