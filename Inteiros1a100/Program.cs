using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inteiros1a100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Impar(1), Par(0)");
            int opcao = int.Parse(Console.ReadLine());

            int cont = opcao;

            while (cont <= 20)
            {
                Console.WriteLine(cont);
                cont+=2;
            }

            Console.ReadKey();
        }
    }
}
