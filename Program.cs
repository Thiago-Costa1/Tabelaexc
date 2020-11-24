using System;

namespace Exc5
{
    class Program
    {
        static void Main(string[] args)
        {
             {
             Console.WriteLine("Tabela de multiplicação");
             Console.WriteLine();
             Console.WriteLine("Escreva um número de 1 a 10:\n ");
             int numero = Convert.ToInt16(Console.ReadLine());
             for (int num=0;num<11;num++)
            {   int resultado=num*numero;
                Console.WriteLine();
                Console.WriteLine($"{num}x{numero}={resultado}");}
            }
        }
    }
}
