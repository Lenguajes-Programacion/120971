using System;

namespace practica2
{
    class Program
    {
        //proyecto calculadora
        //en este proyecto se espera realizar operaciones como suma resta, multiplicacion y division  con los siguientes argumentos val1(int) val2(string) val3 (int)
        static void Main(string[] args)
        {
            switch(args[1])// una forma mas eficaz de hacer comparacion de datos sin usar tanto if
            {
                
                case (args[1]) :
                    args[1] = 1;
                    int suma1 = 0;
                    Console.WriteLine("suma ..?");
                     int dato1 = 0;
                    Console.WriteLine("ingrese el primer valor " + dato1);
                     int dato2 = 0;
                    Console.WriteLine("ingrese el segundo dato" + dato2);
                     suma1 = dato1 + dato2;
                    Console.WriteLine("la operacion de suma dio como resultado: " + suma1);
                    break;
                default:
                    Console.WriteLine("esta operacion contiene datos erroneos por favor ingrese valores validos para " + args[1]);
                    break;
            }

        }
    }


}
