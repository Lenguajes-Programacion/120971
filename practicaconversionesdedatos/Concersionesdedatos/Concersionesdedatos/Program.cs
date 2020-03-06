using System;
using System.Collections.Generic;

namespace Concersionesdedatos
{
    class Program
    {
        static void Main(string[] args)
        {
            String midato = "10";
            int convertir1;
            convertir1 = Convert.ToInt32(midato);
            Console.WriteLine("dato convertido : {0}", midato );
            string tiempo ="1999-12-10";
            DateTime tiempol;
            tiempol = DateTime.Parse(tiempo) ;
            Console.WriteLine("dato convertido : {0}", tiempo);
            //ejemplo de listas:
            List<int> listaresultados = new List<int>();
            listaresultados.Add(1);
            listaresultados.Add(2);
            listaresultados.Add(3);
            listaresultados.Add(4);
            listaresultados.Add(5);
            foreach(var dato in listaresultados)
            {
                Console.WriteLine(dato.ToString());
                

           
            }
            

        }
    }
}
