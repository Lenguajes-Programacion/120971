using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace programamenu
{
    class Memoria
    {
        int i;

        // Creando la lista para guardar datos
        public List<MemoriaData> mibasededatos = new List<MemoriaData>();
        public Memoria()
        {
            // Constructor de la clase Memoria, para inicializar nuestra lista
            mibasededatos = new List<MemoriaData>();
        }
        public void LeerMemoria()
        {
           
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            
            foreach (var item in dbObject)
            {
                MemoriaData memoriaData = new MemoriaData(i, item.Key.ToString(), item.Value["operacion"].ToString(), item.Value["resultado"].ToString());
                this.mibasededatos.Add(memoriaData);
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.WriteLine("Operación: {0}", memoriaData.operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.resultado.ToString());
                Console.WriteLine("----------------- \n");
                i++;
            }
        }
        public int GetMemoriaData(String key)
        {
           
            int datos = int.Parse(key);
            MemoriaData data = mibasededatos[datos];
           
            return data.resultado;
        }
        public void GuardarMemoria()
        {

        }
    }
    class MemoriaData
    {
        public int key;
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData(int i, String date, String operation, String result)
        {
            key = i;
            fecha = DateTime.Parse(date);
            operacion = operation;
            resultado = int.Parse(result);
        }
        
    }
    //declaracion de un arreglo.
    public class ejemarreglo
    {
        public void arreglo()
        {
            String [] colores = { "rojo", "blanco", "verde" };
            Array.Sort(colores);
            Array.Reverse(colores);
            Array.ForEach(colores, (item) =>
            {
                Console.WriteLine(item);
            });
            String color = Array.Find(colores, (item) =>{
                return item.Length > 4;
            });
            Console.WriteLine(color);
            //hacer que el usuario agrege los datos al arreglo.
            Console.WriteLine("accede a tus colores y separalos por (,)");
            string coloruser = Console.ReadLine();
             String [] newcolors = coloruser.Split(',');//split sirve para identificar patrones que necesites detectar en este caso detectamos una ,
            Console.WriteLine(newcolors);
            /*String color = Array.FindAll(colores, (item) => {
                return item.Length > 4;
            });
            Console.WriteLine(color);*/
            //List<string> colores2 = [ "rojo", "blanco", "morado" ];
            //para gregar los meotdos debemos poner     Array.sort y vienen diferentes opciones para usarse. la palabra sort es ordenar datos.
            //colores2.Sort();

            //declaracion de unna lista



        }
        public void multidimensional()
        {
            int[,,] array = new int[4, 2, 3];
            Console.WriteLine(array);
        }
        //investigar que usos reales se tienen para los arreglos y ejemplos multidimensionales.
        //agregar dimension a los arreglos:

    }


}