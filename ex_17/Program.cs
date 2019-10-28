using System;

namespace ex_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool exit = false;

            do{

                Console.Clear();

                uint i = 120;

                for (i = 120; i <= 300; i++) {
                    Console.WriteLine (i);
                }
                
                Console.WriteLine ("Quer Sair S/N ?");
                opcao = Console.ReadLine ();

                if(opcao == "s"){
                    exit = true;
                }
            }while(!exit);
        }
    }
}
