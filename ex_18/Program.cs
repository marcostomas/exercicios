using System;

namespace ex_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool exit = false;

            do{

                int impar;
                Console.Clear();
                

                System.Console.WriteLine("Digite um número");
                int num = int.Parse(Console.ReadLine());

                for (int i = 0; i <= num; i++) {
                    impar = i % 2;
                    if(impar != 0){
                        System.Console.Write(i + " ");
                    }
                }
                System.Console.WriteLine();
                
                Console.WriteLine ("Quer Sair S/N ?");
                opcao = Console.ReadLine ();

                if(opcao == "s"){
                    exit = true;
                }
            }while(!exit);
        }
    }
}
