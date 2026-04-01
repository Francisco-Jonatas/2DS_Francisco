using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    internal class Fluxo
    {
        public void Grama()
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Bem Vindo(a) "+nome +", anos "+idade);
        }
    }
}
