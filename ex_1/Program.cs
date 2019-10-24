using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool exit = false;

            do{
                
                Console.Clear();

                System.Console.WriteLine("CALCULE UM RETÂNGULO");
                System.Console.WriteLine();
                System.Console.Write("Insira o comprimento do retângulo: ");
                double comprimento = double.Parse(Console.ReadLine());
                System.Console.WriteLine();
                System.Console.Write("Insira a largura do retângulo: ");
                double largura = double.Parse(Console.ReadLine());

                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine();

                double perimetro = largura*2 + comprimento*2;
                System.Console.WriteLine($"O Perímetro é: {perimetro}");

                double area = largura*comprimento;
                System.Console.WriteLine($"A Área é: {area}");

                double d1 = (largura*largura) + (comprimento*comprimento);
                double diagonal = Math.Sqrt(d1);
                System.Console.WriteLine($"A Diagonal é: {diagonal}");

                System.Console.WriteLine("Deseja Sair S/N ?");
                opcao = Console.ReadLine();

                if(opcao == "n"){
                    exit = true;
                }

            }while (exit);
        }
    }
}