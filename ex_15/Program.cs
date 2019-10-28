using System;
using System.Collections.Generic;

namespace ex_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            int i = 0;

            Dictionary <int, string> mes = new Dictionary <int, string> ();

            mes.Add(1,"Janeiro");
            mes.Add(2, "Fevereiro");
            mes.Add(3, "Março");
            mes.Add(4, "Abril");
            mes.Add(5, "Maio");
            mes.Add(6, "Junho");
            mes.Add(7, "Julho");
            mes.Add(8, "Agosto");
            mes.Add(9, "Setembro");
            mes.Add(10, "Outubro");
            mes.Add(11, "Novembro");
            mes.Add(12, "Dezembro");

            do{

                System.Console.WriteLine("Dgite o número do mês e descubra seu nome");
                i = int.Parse(Console.ReadLine());

                if ((i >= 1) && (i <= 12)){
                    System.Console.WriteLine(mes[i]);
                }else{
                    System.Console.WriteLine("Não existe mês com esse número. Os meses vão de 1 a 12");
                }

                System.Console.WriteLine("Quer Sair s/n ?");
                opcao=Console.ReadLine().ToLower();
                
            }while(opcao != "s");
        }
    }
}
