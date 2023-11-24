using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_004_18_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");
            string senhaUsuario = Console.ReadLine();

            if (senhaUsuario == "1234")
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO");
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
    
