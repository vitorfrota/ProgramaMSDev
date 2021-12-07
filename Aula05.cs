using System; // Declaração das bibliotecas

namespace Aula06 // Declaração dos programas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();

            moto.placa = "xx";
            
            
            static void ExercicioMaior()
            {
                Console.WriteLine("Digite três numeros");

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int n3 = int.Parse(Console.ReadLine());

                int resultado = Maior(n1, n2, n3);

                static int Maior(int num1, int num2, int num3)
                {
                    int maior;

                    if (num1 > num2 && num1 > num3)
                    {
                        maior = num1;
                    }
                    else if (num2 > num3)
                    {
                        maior = num2;
                    }
                    else
                    {
                        maior = num3;
                    }

                    return maior;
                }
                Console.WriteLine("Maior = " + resultado);
            }
        }

        /// ENCAPSULAMENTO - AGRUPADAR O QUE FAZ SENTIDO
        /// ABSTRAÇÃO - ATO DE ESCONDER OS DETALHES
        /// HERANÇA - capacidade de um objeto herdar propriedades, metodos e eventos de outro objeto.

        class Carro
        {
            //  as variaveis se tornam propriedades.
            public string placa;
            public string chassi;

            
            // todas as funções se tornam métodos.
            public void Andar()
            {
                ConsultarQuantidadeCombustivel();

            }

            public void ConsultarQuantidadeCombustivel()
            {

            }

            public void Buzinar()
            {

            }

            private void LigarSeta() { }

            
        }

        class Moto : Carro
        {
            string pezinho;
        }
    }
 }
