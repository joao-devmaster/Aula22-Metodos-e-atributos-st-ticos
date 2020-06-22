using System;

namespace Aula22POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("\r\nDoláres para Reais : " + Conversor.DolarParaReais(52f) );
            

            System.Console.WriteLine("\r\nReais para Doláres : " +  Conversor.RealParaDolar(52) );

             System.Console.WriteLine("\r\nReais para Euro : " +  Conversor.RealParaEuro(52) );

              System.Console.WriteLine("\r\nEuro para Reais : " +  Conversor.RealParaDolar(52) );
        }
    }
}
