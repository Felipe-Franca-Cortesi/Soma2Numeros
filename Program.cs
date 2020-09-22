using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----cálculo da soma entre dois números-----");

            Console.Write("Digite o primeiro valor: ");
            decimal valor1 = Convert.ToDecimal(Console.ReadLine()); 

            Console.Write("Digite o segundo valor: "); 
            decimal valor2 = Convert.ToDecimal(Console.ReadLine()); 

            decimal resultado = valor1 + valor2; 
            Console.WriteLine($" {valor1} + {valor2} = {resultado}");
            
            Console.WriteLine("Pressione qualquer tecla para sair"); 
            Console.ReadKey(); 
        }
    }
}
