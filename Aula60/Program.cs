using Aula60;
using System.Globalization;
ContaBancaria conta;

Console.Write("Digite o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Digite o nome do titular: ");
string titular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char DepInicial = char.Parse(Console.ReadLine().ToUpper());
double valor = 0;


Console.WriteLine();

if (DepInicial == 'S')
{
    conta = new ContaBancaria(numero, titular, valor);
    Console.Write("Entre o valor de depósito inicial: ");
    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta.Depositar(valor);
}
else
    conta = new ContaBancaria(numero, titular);


Console.WriteLine();

Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para deposito: ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Depositar(valor);

Console.WriteLine();

Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

Console.WriteLine();

Console.Write("Entre um valor para saque: ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Sacar(valor);

Console.WriteLine();

Console.WriteLine("Dados da conta:");
Console.Write(conta);


