using System;
using System.Globalization;

namespace csharp_classes_exercicios2
{
    internal class Retangulo
    {
        public double Altura, Largura;

        public double AreaRetangulo()
        {
            double area = Altura * Largura;
            return (area);
        }
        public double PerimetroRetangulo()
        {
            double perimetro = (Altura + Largura) * 2;
            return (perimetro);
        }
        public double DiagonalRetangulo()
        {
            double p = Math.Pow(PerimetroRetangulo(), 2);
            double diagonal = (Math.Sqrt(p - (8 * AreaRetangulo()))) / 2;
            return (diagonal);
        }

        public override string ToString()
        {
            return "AREA: " + AreaRetangulo().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPerimetro: " + PerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDiagonal: " + DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
