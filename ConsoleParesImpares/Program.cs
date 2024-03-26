using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {         

            Console.WriteLine("Digite 0 para selecionar a opção pares e 1 para impares: ");
            int num = int.Parse(Console.ReadLine());

            int cont = num;
            Console.Clear();         
            
                while (cont <=20)
                {
                   Console.WriteLine(cont);

                    cont += 2;

                }       

            Console.ReadKey();
        }
    }
}
