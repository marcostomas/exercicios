using System;

namespace ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string opcao;

            do{

                Console.Clear();

                Console.WriteLine("DIGITE UM NÚMERO INTEIRO");
                uint num = uint.Parse(Console.ReadLine());

                float resultado = (num % 3);

                if (resultado == 0){
                    System.Console.WriteLine("Este número é múltiplo de 3");
                }else{
                    System.Console.WriteLine("Este número não é múltiplo de 3");
                }

                System.Console.WriteLine("Quer Sair S/N ?");
                opcao = Console.ReadLine();

                if(opcao == "s"){
                    exit = true;
                }

            }while(!exit);
        }
    }
}
