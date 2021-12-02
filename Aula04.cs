using System;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
        }

        static void CondicaoIf()
        {
            // IF (SE) -> Operador lógico - TRUE OU FALSE

            int hora = 10;
            Console.WriteLine("Bom dia");

            if (hora > 12)
            {
                Console.WriteLine("Boa tarde!");
            }
        }

        static void CondicaoIfElse()
        {
            // IF (SE) -> Operador lógico - TRUE OU FALSE

            int hora = 10;
            Console.WriteLine("Bom dia");

            if (hora > 12)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Bom dia!");
            }
        }

        static void CondicaoElseIf()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!!");
            }

            else
            {
                Console.WriteLine("Boa noite!!");
            }
        }

        static void SwitchCase()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            switch (hora)
            {
                case 10: Console.WriteLine("Bom dia!"); break;
                case 14: Console.WriteLine("Boa tarde!"); break;
                case 20: Console.WriteLine("Boa noite!"); break;

                default: Console.WriteLine("Dados inválidos"); break;
            }

            string nome = "VITOR";

            switch (nome)
            {
                case "LUCAS": Console.WriteLine("são nomes diferentes!"); break;
                case "VITOR": Console.WriteLine("mesmo nome!!"); break;
                default: Console.WriteLine("nome inválido!!"); break;
            }
        }

        static void While()
        {
            int numero = 1;
            int soma = 0;

            while (numero != 0)
            {
                soma += numero;
                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(soma);
        }

        static void DoWhile()
        {
            int numero = 1;

            do
            {
                Console.WriteLine(numero);
                numero++;
            } while (numero <= 100);

            //---------------------------------------

            int numeroUsuario = 0;

            do
            {
                Console.WriteLine("Digite um número:");
                numeroUsuario = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi {0}", numeroUsuario);
            } while (numeroUsuario != 0);
        }

        static void For()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Número do incrementador: {i}");
            }
        }
    }
}
