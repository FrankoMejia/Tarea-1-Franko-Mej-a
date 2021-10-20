using System;

namespace Primera_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
         

         int a; //Declaramos la variable como un entero
         a = 1500; // Y le asignamos un valor
         int b;
         b = 2500;
         int c = 3500; //Resumimos la expresión

         
         Console.Write("a = "); Console.WriteLine(a); // Y mostramos el valor de las variables 
         Console.Write("b = "); Console.WriteLine(b);
         Console.Write("c = "); Console.WriteLine(c);

         Console.WriteLine(" ");


         Console.Write(a); Console.Write(a); Console.Write(c); Console.Write(b); // Aplicamos la combinación de dichas variables (aacb)

         Console.WriteLine(" "); Console.WriteLine(" "); // Colocamos una separación

          
         Console.Write(b); Console.Write(c); Console.Write(a); //(bca)

         Console.WriteLine(" "); Console.WriteLine(" ");

          
         Console.Write(b); Console.Write(c); Console.Write(b); Console.Write(c); //(bcbc)

         Console.WriteLine(" "); Console.WriteLine(" "); // Y cambiamos el orden de las variables en distintas combinaciones

          
         Console.Write(b); Console.Write(b); Console.Write(b); Console.Write(b); //(bbbb)

         Console.WriteLine(" "); Console.WriteLine(" ");

          
         Console.Write(a); Console.Write(b); Console.Write(c); Console.Write(a); // Tal como esta combinación, y así sucesivamente ;)

         // Franko Mejía 
         // C.I: 30.077.625

        }
    }
}
