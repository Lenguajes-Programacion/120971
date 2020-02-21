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
            var result = dbObject.ToString();
            Console.WriteLine(result);
            //fundamentos de un json se necesita un indice, json es una estructura de "key": "value", el value puede ser cualquier cosa string, int, etc.
            //cada parentesis de un json es un nivel de acceso.
        }
    }
}
