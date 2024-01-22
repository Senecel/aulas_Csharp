using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trocar_valores_sem_auxiliar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Trocar o valor de duas variáveis sem usar uma variável auxiliar.*/
            int a, b;
            Console.WriteLine("Informe o 1º número");
            Console.WriteLine("Informe o 2º número");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Valores informados \n" + a + "   " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Valores trocados \n" + a + "   " + b);
            Console.ReadKey();
        }
    }
}
