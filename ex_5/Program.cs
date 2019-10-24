using System;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool exit = false;

            do{

                Console.Write("Defina um valor para A: ");
                double a = double.Parse(Console.ReadLine());
                System.Console.Write("Defina um valor para B: ");
                double b = double.Parse(Console.ReadLine());

                System.Console.WriteLine();

                System.Console.WriteLine($"Agora A é: {b}");
                System.Console.WriteLine($"E, agora B é: {a}");

                System.Console.WriteLine();

                Console.WriteLine("Quer Sair S/N ?");
                opcao = Console.ReadLine();
                

                if(opcao == "s"){
                    exit = true;
                }
            }while(!exit);
        }
    }
}
