using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class dobrar
    {
        public void dobro()
        {
            Console.WriteLine("Insira um Numero");
            int num1 = int.Parse(Console.ReadLine());
            int dobro = num1 * 2;
            Console.WriteLine("O Numero Dobrado:" +dobro);
        }
    }
}
