using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            bool exit = false;

            do{

                Console.Clear();

                Console.WriteLine("CALCULE O QUANTO FOI GASTO DE COMBUSTÍVEL  NA SUA VIAGEM");
                System.Console.WriteLine();

                System.Console.Write("Digite a distância em quilômetros: ");
                uint distancia = uint.Parse(Console.ReadLine());

                System.Console.Write("Digite o tempo gasto em horas: ");
                uint tempo = uint.Parse(Console.ReadLine());



                uint vmedia = distancia / tempo;

                uint tempom = tempo * 60;

                uint distanciam = distancia * 1000;

                uint kml = distancia / 12;


                System.Console.WriteLine("==============================================");
                System.Console.WriteLine("                RESULTADOS");
                System.Console.WriteLine("==============================================");

                System.Console.WriteLine($"Sua velocidade média foi: {vmedia} Km/h");
                System.Console.WriteLine();
                System.Console.WriteLine($"Seu tempo gasto foi de: {tempom} minutos ou {tempo} horas");
                System.Console.WriteLine();
                System.Console.WriteLine($"A distância percorrida foi de: {distancia} Km ou {distanciam} metros");
                System.Console.WriteLine();
                System.Console.WriteLine($"Você gastou: {kml} Litros");

                System.Console.WriteLine("Quer Sair S/N ?");
                opcao = Console.ReadLine();

                if (opcao == "s"){
                    exit = true;
                }
            
            }while(!exit);
        }
    }
}
