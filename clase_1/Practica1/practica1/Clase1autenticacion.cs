using System;

class Autenticacion {
  public static void Main (string[] args) 
  {
    string nombre1="";
    string nombre2="";
    Console.WriteLine ("ingresa tu nombre");
nombre1= Console.ReadLine();
    Console.WriteLine("Ingresa tu segundo nombre");
    nombre2=Console.ReadLine();
     if(nombre1=="Francisco" && nombre2 =="Daniel"){
           Console.WriteLine("bienvenido loco");
        }
    else{
           Console.WriteLine("Lo siento pero usted no es el loco");
        }
  }
}