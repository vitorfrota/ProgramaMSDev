using System;
using System.Globalization;

namespace ExerciciosAula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // exercicioUm();
             // exercicioDois();
        }

        static void exercicioUm()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");

            Console.WriteLine("Medida com oito casas decimais: {0}", medida);
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }

        static void exercicioDois()
        {
            // A quantidade de alunos para calcular as notas
            int _quantidadeAlunos = 5;

            double[] notas = new double[_quantidadeAlunos];
            double somaNotas = 0;

            for (int i = 0; i < _quantidadeAlunos; i++)
            {
                Console.WriteLine($"Nota do aluno {i + 1}");
                string _nota = Console.ReadLine();

                if (double.TryParse(_nota, out double nota))
                {
                    notas[i] = nota;
                }

                somaNotas += notas[i];
            }

            double mediaAlunos = (somaNotas / _quantidadeAlunos);

            Console.WriteLine("----------------------");
            Console.WriteLine($"A média de alunos é: {mediaAlunos}");
        }
    }
}
