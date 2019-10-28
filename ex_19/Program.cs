using System;

namespace ex_19 {
    class Program {
        static void Main (string[] args) {

            System.Console.WriteLine ("Digite um número para a quantidade de posições de um vetor");
            int n = int.Parse (Console.ReadLine ());

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++) {
                System.Console.WriteLine ("Digite um número para este campo");
                vetor [i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine();

            foreach (int a in vetor) {
                System.Console.WriteLine (a);
            }

        }
    }
}