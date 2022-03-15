using System;

namespace Fernando
{
    class ConversorDeMoedas
    {
        public static double Conversor(double c, double d)
        {
            d += d * 6 / 100;
            return c * d;
        }
    }
}