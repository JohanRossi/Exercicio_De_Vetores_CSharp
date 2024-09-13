using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write($"Quantas pessoas você gostaria de registrar? ");
            int qtdpessoas = int.Parse( Console.ReadLine() );

            string[] nomes = new string[qtdpessoas];
            int[] idades = new int[qtdpessoas];

            for (int i = 0; i < qtdpessoas; i++)
            {
                Console.Write("Digite o nome da pessoa: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Qual a idade da pessoa: ");
                idades[i] = int.Parse( Console.ReadLine() );

                Console.Write('\n');
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.Write('\n');
            }

            for (int i = 0; i < qtdpessoas; i++)
            {
                Console.WriteLine($"{nomes[i]} tem {idades[i]} anos.");
            }
        }
    }
}
