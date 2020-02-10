using System;

namespace practica2calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "e";
            while (salir == "e")
            {
                Console.WriteLine("calculadora");
                Console.WriteLine("elija una opcion de las siguientes");
                Console.WriteLine("a suma");
                Console.WriteLine("b resta");
                Console.WriteLine("c multiplicacion");
                Console.WriteLine("d division");
                Console.WriteLine("e salir");



                
                string opcion;
                int valor1 = 0;
                int valor2 = 0;
                int resultado = 0;
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "a":
                        Console.WriteLine("ingresa el primer valor");
                        valor1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingresa el segundo valor");
                        valor2 = int.Parse(Console.ReadLine());
                        resultado = calculadora.suma(valor1, valor2);
                        Console.WriteLine("el resultado es {0} \n", resultado);
                        break;
                    case "b":
                        Console.WriteLine("ingresa el primer valor");
                        valor1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingresa el segundo valor");
                        valor2 = int.Parse(Console.ReadLine());
                        resultado = calculadora.resta(valor1, valor2);
                        Console.WriteLine("el resultado es {0} \n", resultado);
                        break;
                    case "c":
                        Console.WriteLine("ingresa el primer valor");
                        valor1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingresa el segundo valor");
                        valor2 = int.Parse(Console.ReadLine());
                        resultado = calculadora.multi(valor1, valor2);
                        Console.WriteLine("el resultado es {0} \n", resultado);
                        break;
                        Console.WriteLine("ingresa el primer valor");
                        valor1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingresa el segundo valor");
                        valor2 = int.Parse(Console.ReadLine());
                        resultado = calculadora.division(valor1, valor2);
                        Console.WriteLine("el resultado es {0} \n", resultado);
                    case "d":
                        break;
                    default:
                        Console.WriteLine("ha ingresado una opcion no valida, por favor intente de nuevbo");
                        break;
                }
            }

        }
    }
    class calculadora
    {
        
        public static int suma(int valor1, int valor2) {
            int resultado = 0;
            resultado = valor1 + valor2;
            return resultado;
        }
        public static int resta(int valor1, int valor2)
        {
            int resultado = 0;
            resultado = valor1 - valor2;
            return resultado;
        }
         public static int multi(int valor1, int valor2)
        {
            int resultado = 0;
            resultado = valor1 * valor2;
            return resultado;
        }
        public static int division(int valor1, int valor2)
        {
            int resultado = 0;
            resultado = valor1 / valor2;
            return resultado;
        }
    }
}
// implementarlo para que haga haga otra operacion con el resultado  anterior