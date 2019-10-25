using System;

namespace ex_9 {
    class Program {
        static void Main (string[] args) {
            bool exit = false;
            string opcao;
            double pesoPlaneta = 0;

            do {

                Console.Clear ();

                Console.WriteLine ("SEU PESO EM OUTRO PLANETA");
                System.Console.WriteLine ();

                System.Console.WriteLine ("Digite um peso qualquer (kg)");
                int pesoTerra = int.Parse (Console.ReadLine ());

                    System.Console.WriteLine ("1 - Mercúrio");
                    System.Console.WriteLine ("2 - Vênus");
                    System.Console.WriteLine ("3 - Marte");
                    System.Console.WriteLine ("4 - Júpiter");
                    System.Console.WriteLine ("5 - Saturno");
                    System.Console.WriteLine ("6 - Urano");
                    int opcaoPlaneta = int.Parse (Console.ReadLine ());

                    switch (opcaoPlaneta) {
                        case 1:
                            pesoPlaneta = (pesoTerra / 10) * 0.37;
                            System.Console.WriteLine ($"O seu peso em Mercúrio seria: {pesoPlaneta} kg");
                            break;

                        case 2:
                            pesoPlaneta = (pesoTerra / 10) * 0.88;
                            System.Console.WriteLine ($"O seu peso em Vênus seria: {pesoPlaneta} kg");
                            break;

                        case 3:
                            pesoPlaneta = (pesoTerra / 10) * 0.38;
                            System.Console.WriteLine ($"O seu peso em Marte seria: {pesoPlaneta} kg");
                            break;

                        case 4:
                            pesoPlaneta = (pesoTerra / 10) * 2.64;
                            System.Console.WriteLine ($"O seu peso em Júpiter seria: {pesoPlaneta} kg");
                            break;

                        case 5:
                            pesoPlaneta = (pesoTerra / 10) * 1.15;
                            System.Console.WriteLine ($"O seu peso em Saturno seria: {pesoPlaneta} kg");
                            break;

                        case 6:
                            pesoPlaneta = (pesoTerra / 10) * 1.17;
                            System.Console.WriteLine ($"O seu peso em Urano seria: {pesoPlaneta} kg");
                            break;

                        default:
                            System.Console.WriteLine ("Opção Inválida!");
                            break;
                    }

                System.Console.WriteLine ("Quer Sair S/N ?");
                opcao = Console.ReadLine ();

                if (opcao == "s") {
                    exit = true;
                }

            } while (!exit);

        }
    }
}