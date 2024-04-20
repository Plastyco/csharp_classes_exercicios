using System.Globalization;

namespace csharp_classes_exercicios2
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario, Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public double AumentoSalario(double porcentagem)
        {
            return Salario += Salario * (porcentagem / 100);
        }
        public override string ToString()
        {
            return Nome + ", " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture) + "R$";
        }
    }
}
