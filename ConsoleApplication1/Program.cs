using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversao_dec_binario
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            Console.Write("Digite um número..:");
            numero = int.Parse(Console.ReadLine());

            int[] v = new int[32];

            for (int i = 0; i < 32; i++)
            {
                v[i] = -1;
            }

            int index = 0;
            while (numero > 0)
            {
                v[index] = numero % 2;
                index++;
                numero = numero / 2;
            }

            int j;

            for (j = index - 1; j >= 0; j--)

            {
                Console.Write(" " + v[j]);
            }

            Console.ReadKey();
        }
    }
}