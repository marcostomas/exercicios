using System;

namespace ex_8 {
    class Program {
        static void Main (string[] args) {
            string opcao;
            bool exit = false;

            do {

                Console.WriteLine ("Digite a altura do triângulo");
                int h = int.Parse (Console.ReadLine ());

                for (int i = 0; i <= h; i = i -1) {
                    for(int n = 0; n < i ; i++){
                        System.Console.WriteLine("/*");
                    }
                }

                System.Console.WriteLine("Deseja Sair S/N ?");
                opcao = Console.ReadLine();
                
                if (opcao == "s"){
                    exit = true;
                }
            }while (!exit);
        }
    }
}
