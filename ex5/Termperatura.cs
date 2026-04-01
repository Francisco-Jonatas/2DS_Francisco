using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Termperatura
    {
        public double celsius()
        {
            Console.WriteLine("Insira uma temperatura em Celsius");
            double Celsius = double.Parse(Console.ReadLine());
            double Fahrenheit = Celsius * 9 / 5 + 32;
            Console.WriteLine(" Fahrenheit" +Fahrenheit);
            return Fahrenheit;
        }

    }
}
