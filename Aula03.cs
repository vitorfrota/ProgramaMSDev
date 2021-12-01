using System.Globalization;

namespace Aula03
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Saida();
        }

        public static void Inicio()
        {
            // Como declarar uma variável (TIPO NOME;)

            string name = "Vitor";
            int age = 24;

            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        public static void OperadorAritmetico()
        {
            int primeiro = 1;
            int segundo = 10;
            int terceiro = 20;

            Console.WriteLine("Soma de todos os numeros: " + (primeiro + segundo + terceiro));
            Console.WriteLine("Subtração de todos os numeros: " + (terceiro - segundo - primeiro));
            Console.WriteLine("Multiplicação de todos os numeros: " + (primeiro * segundo * terceiro));
            Console.WriteLine("Divisão de todos os numeros: " + (terceiro / segundo));
        }

        public static void OperadorAtribuicao()
        {
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("-----");

            a += 2;

            Console.WriteLine(a);
            Console.WriteLine("-----");

            string alfabeto = "ABC";
            alfabeto += "DEF";
            Console.WriteLine(alfabeto);

            a *= 3;
            Console.WriteLine(a);
        }

        public static void OperadorRelacional()
        {
            int number = 10;

            bool result = number > 10;

            Console.WriteLine(result);

            bool menor = number < 30;
            bool maiorIgual = number >= 30;
            bool igual = (number == 10);
            bool diferente = (number != 10);

            Console.WriteLine("O valor da resposta menor: " + menor);
            Console.WriteLine("O valor da resposta maiorIgual: " + maiorIgual);
            Console.WriteLine("O valor da resposta igual: " + igual);
            Console.WriteLine("O valor da resposta diferente: " + diferente);
        }

        public static void OperadorLogico()
        {
            int salario1 = 100;
            int salario2 = 50;
            int salario3 = 200;

            // Quero saber se o salario1 é maior que o 2 e tbm maior que 3.

            bool resultadoSalario = salario1 > salario2 && salario1 > salario3;

            Console.WriteLine(resultadoSalario);

            // Quero saber se o salario 2 menor que o salario 1 ou maior que salario 3

            bool resultadoSalario2 = salario2 < salario1 || salario2 > salario3;

            Console.WriteLine(resultadoSalario2);

            // Quero saber se o salario2 é maior que o salario3

            bool resultadoSalario3 = !(salario2 > salario3);

            Console.WriteLine(resultadoSalario3);
        }

        public static void Saida()
        {
            int idade = 24;
            double saldo = 1.1981234;
            string nome = "Vitor";

            // interpolação
            Console.WriteLine("{0} tem {1} anos de idade e saldo de {2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos de idade e saldo de {saldo} reais");

            // F2 define a quantidade de casas 
            Console.WriteLine(saldo.ToString("F2"));

            // altera virgula para ponto
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
