using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem:
            Soma.*/
            int n1, n2 = 0;
            int resultado = 0;
            Console.Write("Digite o Primeiro Número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo Número: ");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 * n2;
            Console.WriteLine("A multiplicação é {0}", resultado);

            Console.ReadKey();

        }
    }
}
