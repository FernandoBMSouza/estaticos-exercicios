using System;
using System.Globalization;

namespace Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorEmReais = ConversorDeMoedas.Conversor(cotacao, dolares);

            System.Console.WriteLine($"Valor a ser pago em reais = {valorEmReais.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}