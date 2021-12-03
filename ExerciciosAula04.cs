using System;
using System.Linq;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //   ExercicioUm();
         //   ExercicioDois();
         //   ExercicioTres();
        }

        static void ExercicioUm()
        {
            /*

             1 – Crie um algoritmo no qual o usuário/aluno deverá informar informar seu nome e 
             quatro notas. O programa deverá calcular sua média e informar se o aluno foi 
             aprovado ou não. O número seis é o valor mínimo para aprovação.

         */

            int _quantidadeNotas = 4;

            Console.WriteLine("Informe seu nome:");
            string nomeAluno = Console.ReadLine();

            double[] notas = new double[_quantidadeNotas];
            double somaNotas = 0;

            for (int i = 0; i < _quantidadeNotas; i++)
            {
                Console.WriteLine("Informe a nota {0}:", i + 1);
                string _nota = Console.ReadLine();

                if (double.TryParse(_nota, out double nota))
                {
                    notas[i] = nota;
                }

                somaNotas += notas[i];
            }

            double mediaAluno = (somaNotas / _quantidadeNotas);

            Console.WriteLine("----------------------");
            Console.WriteLine("Olá, {0}", nomeAluno);
            Console.WriteLine("Você obteve a média de {0} pontos", mediaAluno);

            if (mediaAluno < 6)
            {
                Console.WriteLine("Infelizmente você foi reprovado. :(");
            }
            else
            {
                Console.WriteLine("Parabéns!!! Você foi aprovado. :D");
            }
        }

        static void ExercicioDois()
        {
            /*
                2 - CRIE UM ALGORITMO QUE LÊ 3 NÚMEROS INTEIROS E RETORNE QUAL É O MAIOR
            */

            int _quantidadeNumeros = 3;
            int[] numerosInteiros = new int[_quantidadeNumeros];

            for (int i = 0; i < _quantidadeNumeros; i++)
            {
                Console.WriteLine("Informe o número {0}:", i + 1);
                string _numero = Console.ReadLine();

                if (int.TryParse(_numero, out int numero))
                {
                    numerosInteiros[i] = numero;
                }
            }

            int maiorNumero = numerosInteiros.Max();
            Console.WriteLine("O maior número da lista é: {0}", maiorNumero);
        }

        static void ExercicioTres()
        {
            /*
                Uma empresa concederá um aumento de salário aos seus funcionários, variável de acordo com o cargo, conforme a tabela abaixo.
                Programa que lê o salário e o código do cargo de um funcionário e calcula o novo salário.
                Se o cargo do funcionário não estiver na tabela, ele recebe 40% de aumento.
                       Código           Cargo              Aumento
                        1               gerente             10%
                        2               engenheiro          20%
                        3               técnico             30%
                No final é mostrado o salário antigo e o novo salário.
             */

            Console.WriteLine("Informe o código do funcionário:");
            int codigoFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salário do funcionário:");
            double salarioFuncionario = double.Parse(Console.ReadLine());

            double novoSalario = 0;

            switch (codigoFuncionario)
            {
                case 1:
                    {
                        novoSalario = ((salarioFuncionario * 10) / 100) + salarioFuncionario;
                        break;
                    }
                case 2:
                    {
                        novoSalario = ((salarioFuncionario * 20) / 100) + salarioFuncionario;
                        break;
                    }
                case 3:
                    {
                        novoSalario = ((salarioFuncionario * 30) / 100) + salarioFuncionario;
                        break;
                    }
                default:
                    {
                        novoSalario = ((salarioFuncionario * 40) / 100) + salarioFuncionario;
                        break;
                    }
            }

            Console.WriteLine("Salário antigo: R${0}", salarioFuncionario);
            Console.WriteLine("Salário atualizado: R${0}", novoSalario);
        }
    }
}
