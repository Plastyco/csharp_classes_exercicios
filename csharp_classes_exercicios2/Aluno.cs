using System.Globalization;

namespace csharp_classes_exercicios2
{
    internal class Aluno
    {
        public string Nome;
        public double NotaPrimeiroTrimestre, NotaSegundoTrimestre, NotaTerceiroTrimestre;

        public double NotaTotal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
        }

        public override string ToString()
        {
            string texto = "Nota final = " + NotaTotal();
            if (NotaTotal() >= 60)
            {
                texto += "\nAprovado";
            } else
            {
                texto += "\nReprovado"
                    + "\nFaltaram " + (60 - NotaTotal()).ToString("F2", CultureInfo.InvariantCulture) + " pontos";
            }
            return texto;
        }
    }
}
