using System;
using System.Collections.Generic;

namespace Delegados_Predicados_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>();

            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,
                                        12, 13, 14, 15, 16, 17, 18, 19, 20});

            Predicate<int> ElPredicado1 = new Predicate<int>(CondicionNumerosPrimos);

            List<int> NumerosEncontrados = numeros.FindAll(ElPredicado1);

            Console.WriteLine("Números primos del 1 al 20");
            foreach (int elementos in NumerosEncontrados)
            {
                Console.WriteLine(elementos);
            }

            Predicate<int> ElPredicado2 = new Predicate<int>(CondicionNumerosPares);

            NumerosEncontrados = numeros.FindAll(ElPredicado2);
            
            Console.WriteLine();
            Console.WriteLine("Números pares encontrados:");
            foreach (int elementos in NumerosEncontrados)
            {
                Console.WriteLine(elementos);
            }

            Predicate<int> ElPredicado3 = new Predicate<int>(CondicionNumerosImpares);

            NumerosEncontrados=numeros.FindAll(ElPredicado3);

            Console.WriteLine();
            Console.WriteLine("Números impares encontrados:");
            foreach (int elementos in NumerosEncontrados)
            {
                Console.WriteLine(elementos);
            }

        }

        static bool CondicionNumerosPrimos(int numeros)
        {
            
            if (numeros<2) return false;

            for(int i = 2; i<=Math.Sqrt(numeros); i++)
            {
                if (numeros % i == 0)
                    return false;
            }

            return true;
            
        }

        static bool CondicionNumerosPares(int numeros)
        {
            if (numeros % 2 == 0)
            {
                return true;
            }
            else
                return false;     
        }

        static bool CondicionNumerosImpares(int numeros)
        {
            if (numeros % 2 != 0)
                return true;
            else
                return false;
        }
    }
}
