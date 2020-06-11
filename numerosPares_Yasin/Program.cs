using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosPares_Yasin
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int numero;

            Console.WriteLine("Digite un numero por favor");
            Console.WriteLine();
            entrada = Console.ReadLine();
            numero = Convert.ToInt32(entrada);

            if ((numero % 2) == 0)
            {
                Console.WriteLine("El número es par");
            }
            else 
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadLine();
        }
    }
}
