using System;

namespace signo
{
    public class Program
    {
       public static void Signo(float n)
       {
            //Hacemos los if para resolver los puntos a resolver, faltaria cuando es uno para decimal.
            
            if (n >0)
            Console.WriteLine("1");
            if (n == 0) 
            Console.WriteLine("0");
            if (n < 0) 
            Console.WriteLine("-1");
            
            
            
        }   


        public static void Main()
        {
            float n;
            
           // en esta parte declaro las variables ,la interacion con el usuario y llamo a la funcion. 

            Console.WriteLine("ingrese un numero real : ");
            n =Convert.ToSingle( Console.ReadLine());
            Signo(n);
            Console.ReadKey();
        }
        
    }
}
