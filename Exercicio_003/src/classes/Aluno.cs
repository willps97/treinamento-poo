using System;


namespace Exercicio_003.src.classes
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Aluno()
        {
        }

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double RestoNota()
        {
            if(Aprovado() == true)
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }

    }
  
}
