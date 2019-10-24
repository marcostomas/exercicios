using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            bool exit = false;

            do{

                Console.Clear();

                Console.WriteLine("CONVERSÃO DE GRAUS CELSIUS PARA FAHRENHEIT");
                System.Console.WriteLine();

                System.Console.Write("Insira o valor em °C: ");
                double C = double.Parse(Console.ReadLine());
                System.Console.WriteLine();

                double F = (C * 9) / 5 + 32;

                System.Console.WriteLine($"O valor em Fahrenheit é: {F} °F");

                System.Console.WriteLine("Quer Sair S/N ?");
                opcao = Console.ReadLine();

                if(opcao == "s"){
                    exit = true;
                }
        
            }while(!exit);
        }
    }
}
