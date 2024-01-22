using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerdoisnumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            //informe os números.
            //armazena na variavel n1
            Console.Write("Informe o 1º número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe o 2º número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("os números são {0} e {1}", a,b);
            Console.ReadKey();
        }
    }
}
