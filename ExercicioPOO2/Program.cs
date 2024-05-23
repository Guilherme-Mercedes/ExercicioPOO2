using System.Globalization;

namespace ExercicioPOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();

        }

        /* 1 -Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            seguida, mostrar na tela o valor de sua área, perímetro e diagonal.*/
        static void Exercicio1()
        {
            Triangulo t = new Triangulo();

            Console.WriteLine("Digite a largura e a altura do triangulo");
            Console.Write("Largura: ");
            t.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            t.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area: " + t.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + t.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + t.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        /* 2- Fazer um programa para ler os dados de um funcionário (nome,
            salário bruto e imposto). Em seguida, mostrar os dados do
            funcionário (nome e salário líquido). Em seguida, aumentar o salário
            do funcionário com base em uma porcentagem dada (somente o
            salário bruto é afetado pela porcentagem) e mostrar novamente os
            dados do funcionário*/
        static void Exercicio2()
        {
            double pctg;
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite os dados do funcionario: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Funcionario: " + f);

            Console.WriteLine("");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            pctg = double.Parse(Console.ReadLine());
            f.AumentarSalario(pctg);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + f);
        }

        /* 3- Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
            este problema.*/

        static void Exercicio3()
        {
            Aluno a = new Aluno();
            Console.Write("Digite o Nome do Aluno:");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno:");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a.Aprovado())
            {
                Console.WriteLine("NOTA FINAL: " + a.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");

            }
            else
            {
                Console.WriteLine("NOTA FINAL: " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "PONTOS");
            }

        }
    }
}
