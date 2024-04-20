using csharp_classes_exercicios2;
using System.Globalization;

Console.WriteLine("Escolha um exercício de 1 a 3: ");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Exercicio1();
        break;
    case 2:
        Exercicio2();
        break;
    case 3:
        Exercicio3();
        break;
}

static void Exercicio1()
{
    Retangulo a = new Retangulo();
    Console.WriteLine("Escreva a largura e a altura de um retangulo");
    Console.Write("Largura: ");
    a.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Altura: ");
    a.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine(a);
}
static void Exercicio2()
{
    Funcionario a = new Funcionario();
    Console.WriteLine("Escreva os dados do funcionario");
    Console.Write("Nome: ");
    a.Nome = Console.ReadLine();
    Console.Write("Salário: ");
    a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Imposto: ");
    a.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Funcionário: " + a);
    Console.Write("Digite a porcentagem para aumentar o salário: ");
    a.AumentoSalario(double.Parse(Console.ReadLine()));
    Console.WriteLine("Dados atualizados: " + a);
}
static void Exercicio3()
{
    Aluno a = new Aluno();

    Console.WriteLine("Insira as informaçõe do aluno");
    Console.Write("Nome: ");
    a.Nome = Console.ReadLine();
    Console.WriteLine("Digite as três notas no aluno");
    Console.Write("Primeiro trimestre: ");
    a.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Segundo trimestre: ");
    a.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Terceiro trimestre: ");
    a.NotaTerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine(a);
}