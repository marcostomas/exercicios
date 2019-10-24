using System;

namespace ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool exit = false;

            do{

                Console.Clear();

                uint i = 0;

                for (i = 0; i <= 10; i++) {
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
