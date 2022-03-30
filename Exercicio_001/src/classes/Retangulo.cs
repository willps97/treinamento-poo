using System;


namespace Exercicio_001.src.classes
{
    class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double Area(double altura, double largura)
        {
            double a = largura * altura;

            return a;
        }
        public double Perimetro(double altura, double largura)
        {
            double p = (2 * largura + 2 * altura);

            return p;
        }
        public double Diagonal(double altura, double largura)
        {
            double d = Math.Sqrt((largura * largura) + (altura * altura));

            return d;

        }
    }
}
