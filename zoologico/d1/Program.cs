using System;

namespace d1
{
            // enum animais : uint {
            //     Tubarão_Martelo = 1,
            //     Tucano,
            //     Arara,
            //     Leão, 
            //     Orangotango, 
            //     Chimpanze, 
            //     Pinguim, 
            //     Tartaruga, 
            //     Golfinho
            // };
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Aniamais Na Jaula (1.1)");
            System.Console.WriteLine(" 1 - Tubarão Martelo");
            System.Console.WriteLine(" 2 - Tucano");
            System.Console.WriteLine(" 3 - Arara");
            System.Console.WriteLine(" 4 - Leão");
            System.Console.WriteLine(" 5 - Orangotango");
            System.Console.WriteLine(" 6 - Chimpanzé");
            System.Console.WriteLine(" 7 - Pinguim");
            System.Console.WriteLine(" 8 - Tartaruga");
            System.Console.WriteLine(" 9 - Golfinho");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                System.Console.WriteLine("O Tubarão Martelo foi para o Aquário");
                break;

                case 2:
                System.Console.WriteLine("O Tucano foi para a Gaiola");
                break;

                case 3:
                System.Console.WriteLine("A Arara foi pra a Gaiola");
                break;

                case 4:
                System.Console.WriteLine("O Leão foi para a Caverna de Pedra");
                break;

                case 5:
                System.Console.WriteLine("O Orangotango foi para a Casa em Árvore");
                break;

                case 6:
                System.Console.WriteLine("O Chimpanzé foi pra a Casa em Árvore");
                break;

                case 7:
                System.Console.WriteLine("O Pinguim foi para a Piscina Gelada");
                break;

                case 8:
                System.Console.WriteLine("A Tarataruga foi para o Aquário");
                break;

                case 9:
                System.Console.WriteLine("O Golfinho foi para o Aquário");
                break;
            }
            
        }
    }
}
