using System;

//Entrega 100
namespace programamenu
{

    public class Menu1
    {
        public static void Main(string[] args)
       // static void calcu(string[]args)
        {


            string opcion = "";
            do
            {
                Console.WriteLine("menu de seleccion");
                Console.WriteLine("seleccione alguna opcion para ejecutar los programas");
                Console.WriteLine("(y) autenticacion ");
                Console.WriteLine("(n) calculadora");
                Console.WriteLine("(m) memoria");
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
                    case "m":
                        //Memoria leer = new Memoria();
                        //leer.LeerMemoria();
                        //ejemarreglo mostrar = new ejemarreglo();
                        //mostrar.arreglo();
                        // escribirjson caso = new escribirjson();
                        //caso.escribir();
                        //se necesita que se guarde el resultado
                        //crear un metodo que nos regrese el resultado que seleccionemos.
                        //utilizar dicho resultado para hacer una nueva operacion.
                        //guardar la nueva operacion en la base de datos creada en json.
                        //memoria memo = new memoria();
                        //memo.LeerMemoria();
                        //ejemarreglo multidimensional = new ejemarreglo();
                        //multidimensional.multid();
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
        public int resultado = 0;
        public void guardar(int res)
        {
           
            resultado = res;
           
        }
        public void Calculatexas()
        {
            string opcion = "";
            
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int contador = 0;
            


            do
            {
                {
                    Console.WriteLine("calculadora");
                    Console.WriteLine("elija una opcion de las siguientes");
                    Console.WriteLine("a suma");
                    Console.WriteLine("b resta");
                    Console.WriteLine("c multiplicacion");
                    Console.WriteLine("d division");
                    Console.WriteLine("f reutilizar dato");
                    Console.WriteLine("e salir");





                   
                   
                    opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "a":


                            if (contador != 0)
                            {
                                Console.WriteLine("el resultado anterior fue {0}", resultado);
                                Console.WriteLine("ingresa el segundo valor");
                                valor3 = int.Parse(Console.ReadLine());
                                resultado = resultado + valor3;
                                Console.WriteLine("el resultado fue {0}", resultado);
                                
                            }
                            else
                            {

                                Console.WriteLine("ingresa el primer valor");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("ingresa el segundo valor");
                                valor2 = int.Parse(Console.ReadLine());
                                resultado = calculadora.suma(valor1, valor2);
                                Console.WriteLine("el resultado fue: {0}", resultado);
                                contador = contador + 1;

                            }

                            break;
                        case "b":
                            if (contador != 0)
                            {
                                Console.WriteLine("el resultado anterior fue {0}", resultado);
                                Console.WriteLine("ingresa el segundo valor");
                                valor3 = int.Parse(Console.ReadLine());
                                resultado = resultado-valor3;
                                Console.WriteLine("el resultado fue {0}", resultado);
                            }
                            else
                            {
                                Console.WriteLine("ingresa el primer valor");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("ingresa el segundo valor");
                                valor2 = int.Parse(Console.ReadLine());
                                resultado = calculadora.resta(valor1, valor2);
                                Console.WriteLine("el resultado es {0} \n", resultado);
                                contador = contador + 1;
                           
                                
                            }
                            break;
                        case "c":
                            if (contador != 0)
                            {
                                Console.WriteLine("el resultado anterior fue {0}", resultado);
                                Console.WriteLine("ingresa el segundo valor");
                                valor3 = int.Parse(Console.ReadLine());
                                resultado = resultado * valor3;
                                Console.WriteLine("el resultado fue {0}", resultado);
                            }
                            else
                            {
                                Console.WriteLine("ingresa el primer valor");
                                valor1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("ingresa el segundo valor");
                                valor2 = int.Parse(Console.ReadLine());
                                resultado = calculadora.multi(valor1, valor2);
                                Console.WriteLine("el resultado es {0} \n", resultado);
                                contador = contador + 1;
                            }
                            break;
                            
                        case "d":
                            if(contador !=0)
                            {
                                Console.WriteLine("el resultado anterior fue {0}", resultado);
                                Console.WriteLine("ingresa el segundo valor");
                                valor3 = int.Parse(Console.ReadLine());
                                resultado = resultado / valor3;
                                Console.WriteLine("el resultado fue {0}", resultado);
                            }
                            else
                            {
                                Console.WriteLine("ingresa el primer valor");
                                valor1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("ingresa el segundo valor");
                                valor2 = int.Parse(Console.ReadLine());
                                resultado = calculadora.division(valor1, valor2);
                                Console.WriteLine("el resultado es {0} \n", resultado);
                                contador = contador + 1;
                            }
                            
                            break;
                        case "f":
                           


                            break;
                        default:
                            Console.WriteLine("ha ingresado una opcion no valida, por favor intente de nuevo");
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