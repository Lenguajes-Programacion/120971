using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;


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
                        Memoria2 obtenermemo = new Memoria2();
                        obtenermemo.iniciomemoria();
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
    class Calculadora : calculadora
    {
        public int resultado = 0;
        List<Resultados> lstResultados = new List<Resultados>();
        Resultados obtener = new Resultados();
        /* public void guardar(int res)
         {

             resultado = res;

         }*/

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
                    Console.WriteLine("i raiz cuadrada");
                    Console.WriteLine("f reutilizar dato");
                    Console.WriteLine("g lista");
                    Console.WriteLine("h guardar a memoria");
                    Console.WriteLine("e salir");





                   
                   
                    opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "a":


                            if (resultado != 0)
                            {
                                Console.WriteLine("el resultado anterior fue {0}", resultado);
                                Console.WriteLine("ingresa el segundo valor");
                                valor3 = int.Parse(Console.ReadLine());
                                resultado = resultado + valor3;
                                Console.WriteLine("el resultado fue {0}", resultado);
                                // lstResultados.Add(resultado);
                                obtener = new Resultados();
                                obtener.fechaResultado = DateTime.Now;
                                obtener.resultado = resultado;
                                obtener.operacion = "Suma";
                                lstResultados.Add(obtener);
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
                                //lstResultados.Add(resultado);
                                obtener = new Resultados();
                                obtener.fechaResultado = DateTime.Now;
                                obtener.resultado = resultado;
                                obtener.operacion = "Suma";
                                lstResultados.Add(obtener);
                            }

                            break;
                        case "b":
                            if (resultado != 0)
                            {
                                Console.WriteLine("el resultado anterior fue {0}", resultado);
                                Console.WriteLine("ingresa el segundo valor");
                                valor3 = int.Parse(Console.ReadLine());
                                resultado = resultado - valor3;
                                Console.WriteLine("el resultado fue {0}", resultado);
                                // lstResultados.Add(resultado);
                                obtener = new Resultados();
                                obtener.fechaResultado = DateTime.Now;
                                obtener.resultado = resultado;
                                obtener.operacion = "resta";
                                lstResultados.Add(obtener);
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
                                //lstResultados.Add(resultado);
                                obtener = new Resultados();
                                obtener.fechaResultado = DateTime.Now;
                                obtener.resultado = resultado;
                                obtener.operacion = "resta";
                                lstResultados.Add(obtener);

                            }
                            break;
                        case "c":
                            if (resultado != 0)
                            {
                                Console.WriteLine("el resultado anterior fue {0}", resultado);
                                Console.WriteLine("ingresa el segundo valor");
                                valor3 = int.Parse(Console.ReadLine());
                                resultado = resultado * valor3;
                                Console.WriteLine("el resultado fue {0}", resultado);
                                //lstResultados.Add(resultado);
                                obtener = new Resultados();
                                obtener.fechaResultado = DateTime.Now;
                                obtener.resultado = resultado;
                                obtener.operacion = "multiplicacion";
                                lstResultados.Add(obtener);
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
                                //lstResultados.Add(resultado);}
                                obtener = new Resultados();
                                obtener.fechaResultado = DateTime.Now;
                                obtener.resultado = resultado;
                                obtener.operacion = "multiplicacion";
                                lstResultados.Add(obtener);
                            }
                            break;

                        case "d":
                            if (resultado != 0)
                            {
                                Console.WriteLine("el resultado anterior fue {0}", resultado);
                                Console.WriteLine("ingresa el segundo valor");
                                valor3 = int.Parse(Console.ReadLine());
                                resultado = resultado / valor3;
                                Console.WriteLine("el resultado fue {0}", resultado);
                                //lstResultados.Add(resultado);
                                obtener = new Resultados();
                                obtener.fechaResultado = DateTime.Now;
                                obtener.resultado = resultado;
                                obtener.operacion = "division";
                                lstResultados.Add(obtener);
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
                                //lstResultados.Add(resultado);
                                obtener = new Resultados();
                                obtener.fechaResultado = DateTime.Now;
                                obtener.resultado = resultado;
                                obtener.operacion = "division";
                                lstResultados.Add(obtener);
                            }

                            break;
                        case "f": 
                            //creamos una variable para leer nuestro archivo json
                            var leerjson = File.ReadAllBytes("../../../db.json");
                            //asignamos la lista guardada en el json a la variable leerjson
                            lstResultados = JsonSerializer.Deserialize<List<Resultados>>(leerjson);
                            Console.WriteLine("lista de numeros:");
                            int indicecont = 0;
                            foreach(Resultados indice in lstResultados)
                            {
                                Console.WriteLine("indice:"+indicecont+" valor:"+indice.resultado + " fecha:" + indice.fechaResultado + " operacion:" + indice.operacion);
                                indicecont++;
                            }
                            Console.WriteLine("ingrese el indice a utilizar del 0 a "+ (lstResultados.Count-1).ToString());
                            int respuesta = int.Parse(Console.ReadLine());
                            if (respuesta + 1 <= lstResultados.Count && respuesta >= 0)
                                resultado = lstResultados[respuesta].resultado;
                            else
                                Console.WriteLine("opcion no valida,intente de nuevo pillin!!..");
                            break;
                        case "g":
                            foreach (Resultados i in lstResultados)
                            {
                                Console.WriteLine(i.resultado.ToString());
                            }
                            

                            break;
                        case "h":
                            //serializamos la lista creada, agarra un objeto y la serializa en este caso la lista
                            var jsonlist = JsonSerializer.Serialize(lstResultados);
                            //define la ruta donde se van a guardar los datos
                            string ruta = "../../../db.json";
                            //usando un streamwriter crea el archivo, lo abre y escribe en el
                            using (StreamWriter resultados1 = File.CreateText(ruta))
                            {
                                //escribe en el streamwriter la lista ene ste caso lsresultados.
                                resultados1.Write(jsonlist);
                            }
                            Console.WriteLine("los resultados se han guardado en memoria");
                                break;
                        case "i":
                            Console.WriteLine("ingrese el valor para la raiz cuadrada:");
                            valor1 = int.Parse(Console.ReadLine());
                            resultado = calculadora.raiz(valor1);
                            resultado.ToString();
                            //resultado = newcalculadora.raiz(valor1);
                            Console.WriteLine("el resultado es { 0} \n", resultado);
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
        public static int raiz(int valor1)
        {
            int resultado = 0;
            resultado = valor1 * valor1;
            return resultado;
        }

    }
    /*
    class newcalculadora : calculadora
    {
      public void raizcuadrada()
        {
           this.raiz(int valor1);
        }
    }
    */
}