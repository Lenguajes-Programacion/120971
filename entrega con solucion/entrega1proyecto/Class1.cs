using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace entrega1proyecto
{
    class memoria
    {
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
            foreach(var item in dbObject)// var item, convertir un item en db object y este se guarde para despues mostrarlo 
            {
                Console.WriteLine("Dato en memoria:");
                Console.WriteLine(item.ToString());
            }
            //fundamentos de un json se necesita un indice, json es una estructura de "key": "value", el value puede ser cualquier cosa string, int, etc.
            //cada parentesis de un json es un nivel de acceso.
            //arreglos  son asi [], los archivos json no necesitan indices, en caso del arreglo, requiere un indice para poder acceder a los datos
            //foreach busqueda avanzada de datos
        }
    }
}
