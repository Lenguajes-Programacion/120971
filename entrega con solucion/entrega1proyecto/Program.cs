using System;

//Entrega 100
namespace programamenu
{

    public class Menu1
    {
        public static void Main(string[] args)
        {


            string opcion = "";
            do
            {
                Console.WriteLine("menu de seleccion");
                Console.WriteLine("seleccione alguna opcion para ejecutar los programas");
                Console.WriteLine("(y) autenticacion ");
                Console.WriteLine("(n) calculadora");
                Console.WriteLine("(s)Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "y":
                        Autenticacion miembro = new Autenticacion();
                        miembro.sesion();

                        break;
                    case "n":
                        Calculadora calculando = new Calculadora();
                        calculando.Calculatexas();

                        break;
                }

            } while (opcion != "s");
        }
    }
    class Autenticacion
    {
        public void sesion()
        {
            string nombre1 = "";
            string nombre2 = "";
            Console.WriteLine("ingresa tu nombre");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingresa tu segundo nombre");
            nombre2 = Console.ReadLine();
            if (nombre1 == "Francisco" && nombre2 == "Daniel")
            {
                Console.WriteLine("bienvenido loco");
            }
            else
            {
                Console.WriteLine("Lo siento pero usted no es el loco");
            }
        }
    }
    class Calculadora
    {
        public void Calculatexas()
        {
            string opcion = "";
            do
            {
                {
                    Console.WriteLine("calculadora");
                    Console.WriteLine("elija una opcion de las siguientes");
                    Console.WriteLine("a suma");
                    Console.WriteLine("b resta");
                    Console.WriteLine("c multiplicacion");
                    Console.WriteLine("d division");
                    Console.WriteLine("e salir");





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
            } while (opcion != "e");
        }
    }
    class calculadora
    {

        public static int suma(int valor1, int valor2)
        {
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