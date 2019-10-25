using System;

namespace ex_12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string opcao;

            do{

                Console.Clear();

                Console.WriteLine("DIGITE UM NÚMERO");
                int num1 = int.Parse(Console.ReadLine());

                System.Console.WriteLine("DIGITE OUTRO NÚMERO");
                int num2 = int.Parse(Console.ReadLine());

                System.Console.WriteLine("==================================");

                if(num1>num2){
                    System.Console.WriteLine(num2);
                    System.Console.WriteLine(num1);
                } else{
                    System.Console.WriteLine(num1);
                    System.Console.WriteLine(num2);
                }

                System.Console.WriteLine();

                System.Console.WriteLine("Quer Sair S/N ?");
                opcao = Console.ReadLine();

                if (opcao == "s"){
                    exit = true;
                }

            }while(!exit);

        }
    }
}

