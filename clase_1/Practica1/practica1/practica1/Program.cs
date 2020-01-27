using System;

namespace practica1
{
    class Program
    {
        //variable de la clase-
         static string nombre = "Daniel";

        static void Main(string[] args)
        {
            //respondemos con el primer argumento.
            //lenght significa longitud en este caso el tamaño de la caden el doble && significa otra comparacion extra y se debe cumplir las 2 para que acepte el iff el argumento.
            //comparaciones logicas  : >< ,  == , >= , <=  !=
            if (args[0].Length > 0 && args[0] == nombre)//comparacion de boolean verdadeo o falso.
            {
                Console.WriteLine($"hello {args[0]} {args[1]}");
            }
            else
            {
                Console.WriteLine("usuario no reconocido");
            }
        }
    }
}
