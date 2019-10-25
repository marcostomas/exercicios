using System;

namespace ex_13 {
    class Program {
        static void Main (string[] args) {
            
            bool exit = false;
            string opcao;
            
            do{

                Console.Clear ();
                System.Console.WriteLine("Formação de Triângulo");

                Console.WriteLine ("DIGITE UM NÚMERO P/ A HIPOTENUSA DE UM TRIÂNGULO");
                int hip = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("DIGITE UM NÚMERO P/ UM LADO B");
                int b = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("DIGITE UM NÚMERO P/ UM LADO C");
                int c = int.Parse (Console.ReadLine ());

                if(hip > (b + c)){
                    System.Console.WriteLine("Triângulo Formado");
                }else {
                    System.Console.WriteLine("Não é possível formar um triângulo com esses valores");
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