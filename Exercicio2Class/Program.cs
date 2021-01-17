using System;
namespace Exercicio2Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Fucionario dados = new Fucionario();
            Console.Write("Nome : ");
            dados.Nome = Console.ReadLine();
            Console.Write("Salário bruto : ");
            dados.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto : ");
            dados.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Fucionario: " + dados.Nome + (", $ ") + dados.SalarioLiquido().ToString("F2"));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário : ");
            double porcento = double.Parse(Console.ReadLine());
            dados.AumentoSalario(porcento);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + dados);
        }
    }
}
