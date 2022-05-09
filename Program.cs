using System;

namespace challenge4
{
    class Program
    {
       
    public static void Main(string[] args)
    {
        int total = 3;
        Persona[] personas = new Persona[total];
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine("ingresar nombre "+i);
            personas[i] = new Persona()
            {
                Nombre = Console.ReadLine()
            };
        }
 
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(personas[i].ToString());
        }
    }
 
    public class Persona
    {
        public string Nombre { get; set; }
 
        public override string ToString()
        {
            return "mi nombres es " + Nombre;
        }
    }
    }
    
}
    

