﻿using Newtonsoft.Json.Linq;
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
            //foreach(var item in dbObject) var item, convertir un item en db object y este se guarde para despues mostrarlo 
            foreach ((var key, var item) in dbObject)
            {
                Console.WriteLine("Dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now, item["operacion"].ToString(),(int) item["resultado"]);
                DateTime convertir = DateTime.Parse(key);
                Console.WriteLine(convertir);//parse analiza cadenas y lo convierte a lo que se desea https://www.kyocode.com/2019/06/metodo-parse-clase-convert-c/
                Console.WriteLine( key.ToString());
                Console.WriteLine("resultado de la operacion : ");
                Console.WriteLine( memoriaData.resultado.ToString());
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
        public MemoriaData(DateTime date,String operation, int result)
        {
            fecha = date;
            operacion = operation;
            resultado = result;

        }

    }
}
