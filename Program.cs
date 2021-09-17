using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular a área do triangulo retangulo");

            Console.WriteLine();

            Console.Write("Digite a base do triangulo: ");
            string baseValor = Console.ReadLine();
            double baseNumero = Double.Parse(baseValor);

            Console.WriteLine();

            Console.Write("Digite a altura do triangulo: ");
            string alturaValor = Console.ReadLine();
            double alturaNumero = Double.Parse(alturaValor);

            double areaTriagulo = (baseNumero*alturaNumero)/2;

            Console.WriteLine();

            Console.WriteLine("A área do triangulo retangulo é: " + areaTriagulo);
        }
    }
}
