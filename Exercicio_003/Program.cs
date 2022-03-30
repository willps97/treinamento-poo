using System;
using System.Globalization;
using Exercicio_003.src.classes;

namespace Exercicio_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do Aluno " + aluno.Nome + " : ");
            aluno.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + aluno.NotaFinal().ToString("F1"),CultureInfo.InvariantCulture);
            if (aluno.Aprovado() == true)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno.RestoNota());
            }
        }
    }
}
