using System;
using System.Collections.Generic;

namespace ex_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            int [] n = new int [10];
            List <int> pares = new List<int>();
            List <int> impares = new List<int>();

            Random aleatorios = new Random();

            for (int i = 0; i < 10; i++){

                n [i] = aleatorios.Next(0,5000);

                resultado = n [i] % 2;

                if (resultado == 0){
                    pares.Add(n [i]);
                }else {
                    impares.Add(n [i]);
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("Números do Vetor: ");
            
            foreach(int num in n){
                System.Console.Write(num + "  ");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("Números Pares do Vetor: ");
            
            foreach (int anum in pares){
                System.Console.Write(anum + "  ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("Números Ímpares do Vetor: ");
            
            foreach (int bnum in impares){
                System.Console.Write(bnum + "  ");
            }
            
        }
    }
}
