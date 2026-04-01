using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    internal class Sucesso
    {
        public void Numeros()
        {
            Console.WriteLine("Digite um Numero");
            int num = int.Parse(Console.ReadLine());
            int ante = num - 1;
            int suce = num + 1;
            Console.WriteLine("Antecessor: " +ante);
            Console.WriteLine("Numero: " +num);
            Console.WriteLine("Sucessor: " +suce);
        }
    }
}
