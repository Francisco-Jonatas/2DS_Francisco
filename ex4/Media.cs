using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Media
    {
        public double Calculo()
        {
            Console.WriteLine("Insira uma nota");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira uma nota");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira uma nota");
            double num3 = double.Parse(Console.ReadLine());
            double resultado = (num1 + num2 + num3) / 3;
            if (resultado >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

            return resultado;
        }
    }
}
