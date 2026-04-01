using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class conversor
    {
        public void Converter()
        {
            Console.Write("Digite o valor em dólares: ");
            double dolar = double.Parse(Console.ReadLine());
            double taxa = 5.4;
            double real = dolar * taxa;
            Console.WriteLine("Valor em reais R$:" +real);
        }
    }
}
