using System;
using System.Globalization;


namespace Exercicio_002.src.Classes
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }
       
        public double SalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - (SalarioBruto * (Imposto / 100));

            return salarioLiquido;
        }
        public void AumentarSalario(double porcentagem )
        {
           SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }
        public override string ToString()
        {
            return "Funcionário: " + Nome +
                    " R$ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
