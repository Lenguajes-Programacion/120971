using Newtonsoft.Json;
using System;
using System.IO;

namespace entrega1proyecto
{
    class memoria
    {
        /*
        public void LeerMemoria()
        {
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            //prueba de lectura con json
            // var result = dbObject.ToString();
            //Console.WriteLine(result);
            //ejemplo con foreach para ver datos
            //foreach(var item in dbObject) var item, convertir un item en db object y este se guarde para despues mostrarlo 
            foreach ((var key, var item) in dbObject)
            {
                Console.WriteLine("Dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(DateTime.Today, item["operacion"].ToString(), (int)item["resultado"]);// el int despues de item significa que lo esta convirtiendo en un int
                DateTime convertir = DateTime.Parse(key);
                Console.WriteLine(convertir);//parse analiza cadenas y lo convierte a lo que se desea https://www.kyocode.com/2019/06/metodo-parse-clase-convert-c/
                //Console.WriteLine( key.ToString());
                Console.WriteLine("operacion realizada:");
                Console.WriteLine(memoriaData.operacion);
                Console.WriteLine("resultado de la operacion : ");
                //var resultadop = memoriaData.resultado;
                //resultadop = Convert.ToInt32(resultadop);
                //Console.WriteLine(resultadop);
                Console.WriteLine(memoriaData.resultado.ToString());

            }
            //fundamentos de un json se necesita un indice, json es una estructura de "key": "value", el value puede ser cualquier cosa string, int, etc.
            //cada parentesis de un json es un nivel de acceso.
            //arreglos  son asi [], los archivos json no necesitan indices, en caso del arreglo, requiere un indice para poder acceder a los datos
            //foreach busqueda avanzada de datos
        }

    }
    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;
        public MemoriaData(DateTime date, String operation, int result)
        {
            fecha = date;
            operacion = operation;
            resultado = result;

        }

    }

    class memjson
    {
        public string indice;
        public int operacion;
        public int resultado;
        public datojsonmem(string ubicacion, string operadores, int resultados)
        {
            indice = ubicacion;
            operacion = operadores;
            resultado = resultados;
        }
    }
    */
    }

    class escribirjson
    {
        public int indice;
        public int res;

        public void escribir()
        {
            escribirjson guardar = new escribirjson { indice = 1, res = 0 };
            String outputJson = JsonConvert.SerializeObject(guardar);
            File.WriteAllText("../../../db.json", outputJson);
            Console.WriteLine("escribiendo en json");

        }
    }
}
       
 

//investigar que son las listas en c# y que tienen que ver(relacion) con los arreglos. subir en pdf o archivo de github para el lunes.
