using System;
using System.Globalization;
using Exercicio_002.src.Classes;

/*Fazer um programa para ler os dados de um funcionário (nome,salário bruto e imposto).
Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem)
e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.*/

namespace Exercicio_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(funcionario);

            Console.Write("Digite a porcentagem para aumentar o salário do funcionário " + funcionario.Nome + " : ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumento);

            Console.WriteLine("Dados Atualizados: " + funcionario.Nome + ", " + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)); ;


        }
    }
}
