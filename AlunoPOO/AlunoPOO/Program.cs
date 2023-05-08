using System;
using System.Globalization;
namespace AlunoPOO {
    class Program {
        static void Main(string[] args) {
            Aluno aluno;
            aluno = new Aluno();

            Console.WriteLine("Digite o nome do Aluno: ");
            aluno.Nome = (Console.ReadLine());
            Console.WriteLine("Digite a nota do primeiro trimestre: ");
            aluno.Nota1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota do segundo trimestre: ");
            aluno.Nota2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota do terceiro trimestre: ");
            aluno.Nota3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO!");
            }
            else {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM: " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }

        }
    }
}