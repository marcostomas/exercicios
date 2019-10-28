using System;

namespace ex_16
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string opcao;

            do{

                Console.WriteLine("Descubra o seu IMC");
                System.Console.WriteLine();

                System.Console.WriteLine("Digite se nome");
                string paciente = Console.ReadLine();

                System.Console.WriteLine($"Olá, {paciente} ");

                System.Console.Write($"{paciente}, Digite seu peso (kg): ");
                double peso = double.Parse(Console.ReadLine());

                System.Console.Write($"{paciente}, Digite sua Altura (m): ");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura*altura) ;

                if(imc < 18.5){
                    System.Console.WriteLine($"{paciente}, Você está Abaixo do Peso");
                }else if (imc >= 18.5) {
                    System.Console.WriteLine($"{paciente}, Você está em seu peso normal");
                }else if(imc >= 25){
                    System.Console.WriteLine($"{paciente}, Você está acima do peso");
                }else if(imc >= 30){
                    System.Console.WriteLine($"{paciente}, Você está obeso no Nível 1");
                }else if(imc >= 35){
                    System.Console.WriteLine($"{paciente}, Você está obeso no Nível 2");
                }else if (imc >= 40){
                    System.Console.WriteLine($"{paciente}, Gzuis cê vai morre fio");
                }
                
                System.Console.WriteLine();
                System.Console.WriteLine(imc);

                System.Console.WriteLine("Deseja Sair S/N ?");
                opcao = Console.ReadLine();

                if(opcao == "s"){
                    exit = true;
                }
    

            }while(!exit);
        }
    }
}
