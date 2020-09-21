using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----cálculo da soma entre dois números-----");
            Console.Write("Digite o primeiro valor: "); //"valor1" digitado pelo usuário
            decimal valor1 = Convert.ToDecimal(Console.ReadLine()); //conversão dos valores string para decimal
            Console.Write("Digite o segundo valor: "); //"valor2" digitado pelo usuário
            decimal valor2 = Convert.ToDecimal(Console.ReadLine()); //conversão dos valores string para decimal
            decimal resultado = valor1 + valor2; //"resultado" fica armazenado a soma dos valores
            Console.WriteLine($" {valor1} + {valor2} = {resultado}"); //exibe os valores digitados pelo usuário e o resultado da soma
            Console.WriteLine("Pressione qualquer tecla para sair"); //Entrada de qualquer tecla digitada pelo usuário
            Console.ReadKey(); //fim do programa
        }
    }
}
