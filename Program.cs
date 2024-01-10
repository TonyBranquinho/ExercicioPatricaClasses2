using ExercicioPatricaClasses2;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Preencha os dados.");
            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CI);

            double media = (funcionario2.salario + funcionario1.salario) /2;

            Console.WriteLine("Salario medio = " +  media.ToString("F2", CI));
        }
    }
}