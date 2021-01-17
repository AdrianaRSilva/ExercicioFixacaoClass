using System;
using System.Globalization;
namespace ExercicioFixacaoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo Medida = new Retangulo();
            Console.WriteLine("Entre a Largura e Altura do retângulo : ");
            Medida.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Medida.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

           
           Console.WriteLine("AREA = " + Medida.Area().ToString("F2", CultureInfo.InvariantCulture));
           Console.WriteLine("PERIMETRO ="+ Medida.Perimentro().ToString("F2", CultureInfo.InvariantCulture));
           Console.WriteLine("DIAGONAL = "+ Medida.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
