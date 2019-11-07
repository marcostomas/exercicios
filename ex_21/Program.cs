using System;

namespace ex_21
{
    class Program
    {
        static void Main(string[] args)
        {

            double divisao100;

            Console.WriteLine("ATM");
            System.Console.WriteLine("Este caixa possui cédulas de 2, 5, 10, 20, 50 e 100 Reais");

            System.Console.WriteLine();

            System.Console.Write("Digite o Valor do Saque: ");
            int valorsaque = int.Parse(Console.ReadLine());



            if(valorsaque >= 100){
                int valorsaque / 100 = divisao100;

                if(divisao100 = 0){
                    System.Console.WriteLine($"{divisao100} cédulas de R$ 100");
                }else{
                    break;
                }
                
            }
        }
    }
}
