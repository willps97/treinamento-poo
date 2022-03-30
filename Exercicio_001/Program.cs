using System;
using System.Globalization;
using Exercicio_001.src.classes;

/*Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. 
 *Usar uma classe como mostrado no projeto ao lado.*/

namespace Exercicio_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Retangulo ret = new Retangulo(largura, altura);
            Console.WriteLine("Area = " + ret.Area(largura,altura).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + ret.Perimetro(largura,altura).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Diagonal(largura,altura).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
