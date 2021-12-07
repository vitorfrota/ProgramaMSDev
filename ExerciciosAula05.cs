using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
          static void Exercicio01(){
                /*
            1 - Crie um algoritmo no qual o usuário poderá escolher qual operação matemática ele 
                poderá executar, adição, subtração, multiplicação e divisão.
                Como regra você deverá implementar funções que retornam os resultados das operações
                matemáticas.
           */

           Console.WriteLine("Selecione a opção aritmética:");
           Console.WriteLine("1 - Adição");
           Console.WriteLine("2 - Subtração");
           Console.WriteLine("3 - Multiplicação");
           Console.WriteLine("4 - Divisão");

           int opcao = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o primeiro valor:");
           int num1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o segundo valor:");
           int num2 = int.Parse(Console.ReadLine());

           double resultado = calculaValor(num1, num2, opcao);

           Console.WriteLine("O resultado é: " + resultado);

           static double calculaValor(int n1, int n2, int opcao){
               double total;
               switch(opcao){
                   case 1: {
                       total = n1 + n2;
                       break;
                   }
                    case 2: {
                        total = n1 - n2;
                        break;
                   }
                    case 3: {
                        total = n1 * n2;
                        break;
                   }
                    case 4: {
                        total = n1 / n2;
                        break;
                   }
                   default: {
                       total = 0;
                       break;
                   }
               }
               return total;
           }
          }
        }
    }
