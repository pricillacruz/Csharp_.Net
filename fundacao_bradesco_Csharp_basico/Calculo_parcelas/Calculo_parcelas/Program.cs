using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_parcelas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 1370.00, parcelar = 8, resultado;

            resultado = (valor / parcelar);

            Console.Write(resultado);
            Console.ReadLine();
        }
    }
}
